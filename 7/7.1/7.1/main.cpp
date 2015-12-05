#include "phoneBook.h"
#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
	PhoneBook* phoneBook = createPhoneBook();
	ifstream input("phone_book.txt");
	if (!input.is_open())
	{
		cout << "file not found" << endl;
		return 1;
	}	
	while (!input.eof())
	{
		string name = {};
		size_t number = 0;
		input >> name;
		input >> number;
		BookRecord* record = createRecord(name, number);
		push(phoneBook, record);
		
	}
	input.close();
	cout << "Choose the way to sort: " << endl;
    cout << "0 - by name" << endl;
	cout << "1 - by phone" << endl;
	bool byPhoneNumber = false; 
	cin >> byPhoneNumber;
	phoneBook = mergeSort(phoneBook, byPhoneNumber);
	printBook(phoneBook);
	deletePhoneBook(phoneBook);
	return 1;
}