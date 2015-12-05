#pragma once
#include <string>

struct BookRecord;

struct PhoneBook;

PhoneBook *createPhoneBook();

void deletePhoneBook(PhoneBook* phoneBook);

BookRecord* createRecord(std::string name, size_t number);

void push(PhoneBook* phoneBook, BookRecord* newRecord);

BookRecord* pop(PhoneBook* phoneBook);

PhoneBook* reverseBook(PhoneBook* phoneBook);

bool recordFromFirstBookIsForward(PhoneBook* firstBook, PhoneBook* secondBook, bool byPhoneNumber);

PhoneBook* merge(PhoneBook* phoneBook, PhoneBook* tempBook, bool &byPhoneNumber);

PhoneBook* mergeSort(PhoneBook* phoneBook, bool byPhoneNumber);

void printBook(PhoneBook* phoneBook);