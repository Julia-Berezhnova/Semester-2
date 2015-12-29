#include "list.h"
#include <iostream>

using namespace std;

struct ListElement
{
	int number;
	ListElement* next;
};

struct List
{
	ListElement* head;
	ListElement* tail;
};

List* createList(int size)
{ 
	List* newList = new List;
	ListElement* warrior = new ListElement;
	newList->head = warrior;
	warrior->number = 1;
	for (int i = 2; i <= size; ++i)
	{
		ListElement* newWarrior = new ListElement;
		newWarrior->number = i;
		warrior->next = newWarrior;
		warrior = newWarrior;
		if (i == size)
		{
			newWarrior->next = newList->head;
			newList->tail = newWarrior;
		}
	}
	return newList;
}

void deleteElement(int x, List* list)
{
	ListElement* temp = list->head;
	ListElement* previous = list->tail;
	while (true)
	{
		if (temp->number == x)
		{
			if (temp == list->head)
			{
				list->head = temp->next;
				previous->next = temp->next;
			}
			else if (temp == list->tail)
			{
				previous->next = list->head;
				list->tail = previous;	
			}
			else
			{
				previous->next = temp->next;
			}
			delete temp;
			break;
		}
		else
		{
			previous = temp;
			temp = temp->next;
		}
	}
}

int survivor(List* list, int m)
{
	ListElement* temp = list->head;
	int counter = 1; // счетчик, принимающий значения от 1 до m
	while (list->head != list->tail)
	{
		ListElement* f = temp->next;
		if (counter == m)
		{
			deleteElement(temp->number, list);
			counter = 1;
		}
		else
		{
			++counter;
		}
		temp = f;
		
	}
	return temp->number;
}



