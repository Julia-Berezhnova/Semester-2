#include "list.h"

#include <iostream>

struct ListElement
{
	int value;
	ListElement* next;
};

struct List
{
	int numberOfElements;
	ListElement* head;
};

///Returns an empty list
List *createList()
{
	List *newList = new List;
	newList->numberOfElements = 0;
	newList->head = nullptr;
	return newList;
}

void push(List* list, int value)
{
	ListElement* element = new ListElement;
	element->value = value;
	element->next = list->head;
	list->head = element;
	++list->numberOfElements;
}


void addToTail(List* list, int value)
{
	ListElement* temp = list->head;
	while (temp->next != nullptr)
	{
		temp = temp->next;
	}
	ListElement* element = new ListElement;
	element->value = value;
	temp->next = element;
	element->next = nullptr;
	++list->numberOfElements;
}

///Returns head of the list
ListElement *getHead(List *list)
{
	return list->head;
}

int getHeadValue(List* list)
{
	return list->head->value;
}

int getNumberOfElements(List* list)
{
	return list->numberOfElements;
}

int getValue(List* list, int i)
{
	ListElement* temp = list->head;
	int j = 0;
	while (temp != nullptr)
	{
		if (j == i)
		{
			return temp->value;
		}
		++j;
		temp = temp->next;
	}
}

bool isEmpty(List* list)
{
	return (list->numberOfElements == 0);
}

void printList(List* list)
{
	ListElement* temp = list->head;
	if (temp == nullptr)
	{
		std::cout << "The list is empty" << std::endl;
		return;
	}
	while (temp != nullptr)
	{
		std::cout << temp->value << " ";
		temp = temp->next;
	}
	std::cout << std::endl;
}

///Deletes list element from the top
void deleteListElementFromTheTop(List *list)
{
	ListElement *temp = list->head;
	list->head = list->head->next;
	delete temp;
	--list->numberOfElements;
}

///Deletes list
void deleteList(List *list)
{
	while (list->head != nullptr)
	{
		deleteListElementFromTheTop(list);
	}
	delete list->head;
}
