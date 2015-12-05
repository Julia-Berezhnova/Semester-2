#include "phoneBook.h"
#include <iostream>
#include <algorithm>
#include <string>

struct BookRecord
{
	size_t number;
	std::string name;
	BookRecord* next;
};

struct PhoneBook
{
	size_t numberOfRecords;
	BookRecord* head;
};

PhoneBook* createPhoneBook()
{
	PhoneBook* phoneBook = new PhoneBook;
	phoneBook->head = nullptr;
	phoneBook->numberOfRecords = 0;
	return phoneBook;
}

void deletePhoneBook(PhoneBook* phoneBook)
{
	while (phoneBook->head != nullptr)
	{
		BookRecord* temp = phoneBook->head;
		phoneBook->head = temp->next;
		--phoneBook->numberOfRecords;
		delete temp;
	}
	delete phoneBook->head;
}

BookRecord* createRecord(std::string name, size_t number)
{
	BookRecord* record = new BookRecord;
	record->name = name;
	record->number = number;
	record->next = nullptr;
	return record;
}

///Adds new record to the top
void push(PhoneBook* phoneBook, BookRecord* newRecord)
{
	newRecord->next = phoneBook->head;
	phoneBook->head = newRecord;
	++phoneBook->numberOfRecords;
}

///Returns book record from the top,
///then deletes it.
BookRecord* pop(PhoneBook* phoneBook)
{
	BookRecord* deletedRecord = phoneBook->head;
	phoneBook->head = phoneBook->head->next;
	--phoneBook->numberOfRecords;
	deletedRecord->next = nullptr;
	return deletedRecord;
}

///Returns a reversed phone book
PhoneBook* reverseBook(PhoneBook* phoneBook)
{
	PhoneBook* result = createPhoneBook();
	while (phoneBook->head != nullptr)
	{
		push(result, pop(phoneBook));
	}
	deletePhoneBook(phoneBook);
	return result;
}

///Compares two phone records
bool recordFromFirstBookIsForward(PhoneBook* firstBook, PhoneBook* secondBook, bool byPhoneNumber)
{
	if (byPhoneNumber)
	{
		return (firstBook->head->number > secondBook->head->number);
	}
	return (firstBook->head->name > secondBook->head->name);
}

///Returns new sorted book which consists of two given books
PhoneBook* merge(PhoneBook* phoneBook, PhoneBook* tempBook, bool &byPhoneNumber)
{
	PhoneBook* result = createPhoneBook();
	size_t resultSize = phoneBook->numberOfRecords + tempBook->numberOfRecords;

	phoneBook = reverseBook(phoneBook);
	tempBook = reverseBook(tempBook);

	for (size_t i = 0; i < resultSize; ++i)
	{
		if (phoneBook->numberOfRecords && tempBook->numberOfRecords)
		{
			if (recordFromFirstBookIsForward(phoneBook, tempBook, byPhoneNumber))
			{
				push(result, pop(phoneBook));
			}
			else
			{
				push(result, pop(tempBook));
			}
		}
		else if (phoneBook->numberOfRecords)
		{
			push(result, pop(phoneBook));
		}
		else
		{
			push(result, pop(tempBook));
		}
	}
	deletePhoneBook(phoneBook);
	deletePhoneBook(tempBook);

	return result;
}

///Returns a sorted book
PhoneBook* mergeSort(PhoneBook* phoneBook, bool byPhoneNumber)
{
	if (phoneBook->numberOfRecords > 1)
	{
		PhoneBook* tempBook = createPhoneBook();
		size_t middle = phoneBook->numberOfRecords / 2;
		while (phoneBook->numberOfRecords > middle) ///Division a book into two parts
		{
			push(tempBook, pop(phoneBook));
		}
		PhoneBook* sortedFirstPart = mergeSort(phoneBook, byPhoneNumber);
		PhoneBook* sortedSecondPart = mergeSort(tempBook, byPhoneNumber);
		phoneBook = merge(sortedFirstPart, sortedSecondPart, byPhoneNumber);
		deletePhoneBook(sortedFirstPart);
		deletePhoneBook(sortedSecondPart);
		deletePhoneBook(tempBook);
	}
	return phoneBook;
}

///Prints a book
void printBook(PhoneBook* phoneBook)
{
	BookRecord* temp = phoneBook->head;
	while (temp != nullptr)
	{
		std::cout << temp->name << " " << temp->number << std::endl;
		temp = temp->next;
	}
	std::cout << std::endl;
}