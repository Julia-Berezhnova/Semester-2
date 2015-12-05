#include "list.h"
#include <iostream>
using namespace std;

struct ListElement
{
	int value;
	ListElement* next;
};

struct List
{
	ListElement* head;
};

List* createList()
{
	List* newList = new List;
	newList->head = nullptr;
	return newList;
}

void addElement(int x, List* list)
{
	ListElement* newValue = new ListElement;
	newValue->value = x;
	ListElement* temp = list->head;
	ListElement* futurePrevious = nullptr;
	while (true)
	{
		if (list->head == nullptr)
		{
			list->head = newValue;
			newValue->next = nullptr;
			break;
		}
		else if (temp->value > x && temp == list->head)
		{
			newValue->next = list->head;
			list->head = newValue;
			break;
		}
		else if (temp->value > x)
		{
			futurePrevious->next = newValue;
			newValue->next = temp;
			break;
		}
		else if (temp->next == nullptr)
		{
			newValue->next = nullptr;
			temp->next = newValue;
			break;
		}
		futurePrevious = temp;
		temp = temp->next;
	}
}

void deleteElement(int x, List* list)
{
	ListElement* temp = list->head;
	ListElement* previous = nullptr;
	while (temp != nullptr)
	{
		if (temp->value == x)
		{
			ListElement* temp2 = temp;
			if (temp == list->head)
			{
				list->head = list->head->next;
				temp = list->head;
			}
			else if (temp->next == nullptr)
			{
				previous->next = nullptr;
				temp = nullptr;
			}
			else
			{
				previous->next = temp->next;
				temp = temp->next;
			}
			delete temp2;
		}
		else
		{
			previous = temp;
			temp = temp->next;
		}
	}
}

void printList(List* list)
{
	ListElement* temp = list->head;
	while (temp != nullptr)
	{
		cout << temp->value << " ";
		temp = temp->next;
	}
	cout << endl;
}