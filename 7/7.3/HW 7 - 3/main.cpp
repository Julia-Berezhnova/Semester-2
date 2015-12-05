#include "stack.h"
#include <string>
#include <iostream>

using namespace std;

int main()
{
	char value = {};
	Stack *stack = createStack();
	string sequence = {};
	cout << "Enter a sequence of brackets: " << endl;
	cin >> sequence;
	for (int i = 0; i < sequence.size(); ++i)
	{
		if (sequence[i] == '{' || sequence[i] == '[' || sequence[i] == '(')
		{
			push(sequence[i], stack);
		}
		else
		{
			switch (sequence[i])
			{
			case '}': 
					if (isEmpty(stack) || pop(stack) != '{')
					{
						cout << "The sequence is incorrect." << endl;
						deleteStack(stack);
						return 1;
					}
					break;
			case ']':
					if (isEmpty(stack) || pop(stack) != '[')
					{
						cout << "The sequence is incorrect." << endl;
						deleteStack(stack);
						return 1;
					}
					break;
			case ')': 
					if (isEmpty(stack) || pop(stack) != '(')
					{
						cout << "The sequence is incorrect." << endl;
						deleteStack(stack);
						return 1;
					}
					break;
			default: 
					{
						cout << "There is some symbol which is not a bracket." << endl;
						deleteStack(stack);
						return 1;
					}
			}
		}
	}
	if (!isEmpty(stack))
	{
		cout << "The sequence is incorrect." << endl;
		deleteStack(stack);
		return 1;
	}
	cout << "The sequence is correct." << endl;	
	deleteStack(stack);
	return 0;
}