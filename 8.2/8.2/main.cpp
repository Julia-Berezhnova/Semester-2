#include <iostream>
#include "tree.h"

using namespace std;

int main()
{
	Tree* tree = createTree();
	int choice = -1;
	int number = 0;
	cout << "Choose one of the following operation: " << endl;
	cout << "1 - add new value to the tree" << endl;
	cout << "2 - delete a value from the tree" << endl;
	cout << "3 - find a value in the tree" << endl;
	cout << "4 - print the tree from the smallest to the biggest value" << endl;
	cout << "5 - print the tree from the biggest to the smallest value" << endl;
	cout << "6 - close the program" << endl;
	cin >> choice;
	while (choice < 1 || choice > 6)
	{
		cout << "The input is incorrect. Enter a number from 1 to 5." << endl;
		cout << "Choose one of the following operation: " << endl;
		cout << "1 - add new value to the tree" << endl;
		cout << "2 - delete a value from the tree" << endl;
		cout << "3 - find a value in the tree" << endl;
		cout << "4 - print the tree from the smallest to the biggest value" << endl;
		cout << "5 - print the tree from the biggest to the smallest value" << endl;
		cout << "6 - close the program" << endl;
		cin >> choice;
	}
	while (choice != 6)
	{
		switch (choice)
		{
		case 1:
			cout << "Enter a number to add: ";
			cin >> number;
			if (addNumber(tree, number) == 0)
			{
				cout << "The value is already there" << endl;
			}
			else
			{
				cout << "Operation completed" << endl;
			}
			break;
		case 2:
			cout << "Enter a number to delete: ";
			cin >> number;
			if (deleteNumber(tree, number) == 0)
			{
				cout << "No such value in the tree" << endl;
			}
			else
			{
				cout << "Operation completed" << endl;
			}
			break;
		case 3:
			cout << "Enter a needed value: ";
			cin >> number;
			if (belongs(tree, number))
			{
				cout << "The value is in the tree" << endl;
			}
			else
			{
				cout << "The value is not in the tree" << endl;
			}
			break;
		case 4: 
			printTree(tree, 1);
			cout << endl;
			break;
		case 5:
			printTree(tree, 2);
			cout << endl;
			break;
		default:
			{
					cout << "The input is incorrect. Enter a number from 1 to 5." << endl;
					cout << "Choose one of the following operation: " << endl;
					cout << "1 - add new value to the tree" << endl;
					cout << "2 - delete a value from the tree" << endl;
					cout << "3 - find a value in the tree" << endl;
					cout << "4 - print the tree from the smallest to the biggest value" << endl;
					cout << "5 - print the tree from the biggest to the smallest value" << endl;
					cout << "6 - close the program" << endl;
			}
		}
		cin >> choice;
	}
	return 0;
}