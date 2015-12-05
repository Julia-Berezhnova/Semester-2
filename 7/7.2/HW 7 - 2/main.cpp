#include "stack.h"
#include <iostream>
#include <string>

using namespace std;

int main()
{
	Stack* stack = createStack();
	cout << "Enter an arithmetic expression: " << endl;
	string expression;
	getline(cin, expression);
	for (int i = 0; i < expression.length(); ++i)
	{
		if (expression[i] >= '0' && expression[i] <= '9')
		{
			double value = expression[i] - '0';
			push(value, stack);
		}
		else
		{
			switch (expression[i])
			{
			case '+': add(stack);
					  break;
			case '-': subtract(stack);
				      break;
			case '*': multiply(stack);
				      break;
			case '/': divide(stack);
				      break;
			}
		}
	}
	cout << pop(stack) << endl;
	return 0;
}