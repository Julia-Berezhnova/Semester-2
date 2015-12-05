#include "list.h"
#include <string>

struct ListElement
{
	std::string word;
	ListElement *next;
};

struct List
{
	int numberOfElements;
	ListElement *head;
};

///Returns an empty list
List *createList()
{
	List *newList = new List;
	newList->numberOfElements = 0;
	newList->head = nullptr;
	return newList;
}

///Adds element to the top of the list
void addElement(List *list, std::string word)
{
	ListElement *listElement = new ListElement;
	listElement->word = word;
	listElement->next = list->head;
	list->head = listElement;
	++list->numberOfElements;
}

///Returns head of the list
ListElement *getHead(List *list)
{
	return list->head;
}

///Returns word in given list element
std::string getWord(ListElement *element)
{
	return element->word;
}

///Returns list element that is located after the given 
ListElement *getNextListElement(ListElement *element)
{
	return element->next;
}

///Deletes list element from the top
void deleteListElement(List *list)
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
		deleteListElement(list);
	}
	delete list->head;
}