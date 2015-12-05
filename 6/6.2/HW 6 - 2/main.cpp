#include <iostream>
#include "list.h"

using namespace std;

int main()
{
	List* list = createList();
	int x = 0;
	int choice = -1;

	while (choice != 0)
	{
		cout << "Enter a number of operation: " << endl << "0 - exit" << endl << "1 - add value" << endl << "2 - delete value" << endl << "3 - print list" << endl;
		cin >> choice;
		switch (choice)
		{
			case 0:
				cout << "Bye" << endl;
				return 1;				
			case 1:
				cout << "Enter a value: ";
				cin >> x;
				addElement(x, list);
				break;
			case 2:
				cout << "Enter a value to delete: ";
				cin >> x;
				deleteElement(x, list);
				break;
		case 3:
			cout << "The list: " << endl;
			printList(list);
			break;
		default:
			cout << "No such operation" << endl;
		}
	}
}

//Если попытаться добавить в список не интовое значение, программа до бесконечности выводит строчки
//	Enter a number of operation: 
//	0 - exit 
//  1 - add value 
//  2 - delete value 
//  3 - print list
//Если попытаться удалить не интовое значение, происходит то же самое
