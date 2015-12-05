#include <iostream>
#include "stack.h"

using namespace std;

const int maxLength = 1024;

int main()
{
	Stack *operations = createStack();
	char entered[maxLength] = {};
	cout << "Enter an arithmetic expression: " << endl;
	cin >> entered;
	count(entered, strlen(entered));
	return 0;
}