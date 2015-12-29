#include <iostream>
#include <string>
#include <fstream>
#include <locale.h>

using namespace std;

struct Record
{
	string name;
	string phone;
};

const int maxTotal = 100;

struct Book
{
	int total;
	Record book[maxTotal];
};

int main()
{
	setlocale(LC_ALL, "RUS");

	Book book;
	book.total = 0;
	for (int i = 0; i < maxTotal; ++i)
	{
		book.book[i].name = "";
		book.book[i].phone = "";
	}

	string neededName = "";
	string neededPhone = "";
	bool wasHere = false;

	cout << "Welcome to PhoneBook program." << endl << endl;

	ifstream file("phone_book.txt", ios::in);
	if (!file.is_open())
	{
		cout << "No phone book found." << endl;
	}
	else
	{
		file >> book.total;
		for (int i = 1; i <= book.total; ++i)
		{
			file >> book.book[i].name;
			file >> book.book[i].phone;
		}
	}
	file.close();

	int choice = -1;
	while(choice != 0)
	{
		cout << "Enter a number of needed operation: " << endl << "0 - exit" << endl << "1 - add a record" << endl << "2 - find phone by name" << endl << "3 - find name by phone" << endl << "4 - save changes" << endl;
		cin >> choice;
		cout << endl;
		switch (choice)
		{
			case 0:
				cout << "Thank you for choosing our company." << endl << "Have a nice day." << endl;
				return 1;
				break;
			case 1:
				++book.total;
				cout << "Enter a name: ";
				cin >> book.book[book.total].name;
				cout << "Enter a phone: ";
				cin >> book.book[book.total].phone;		
				break;
			case 2:
				cout << "Enter a name: ";
				cin >> neededName;
				for (int i = 1; i <= book.total; ++i)
				{
					if (neededName == book.book[i].name)
					{
						cout << "Phone number of " << neededName << " is " << book.book[i].phone << endl;
						wasHere = true;
						break;
					}
				}
				if (!wasHere)
				{
					cout << "Not found." << endl;
				}
				wasHere = false;
				break;
			case 3:
				cout << "Enter a phone: ";
				cin >> neededPhone;
				for (int i = 1; i <= book.total; ++i)
				{
					if (neededPhone == book.book[i].phone)
					{
						cout << "Name of a person with phone number " << neededPhone << " is " << book.book[i].name << endl;
						wasHere = true;
						break;
					}
				}
				if (!wasHere)
				{
					cout << "Not found." << endl;
				}
				wasHere = false;
				break;
			case 4:
				ofstream result;
				result.open("phone_book.txt");
				result << book.total << endl;
				for (int i = 1; i <= book.total; ++i)
				{
					result << book.book[i].name << " " << book.book[i].phone << endl;
				}
				cout << "Changes are saved." << endl;
				break;
		}
	}
	return 0;
}