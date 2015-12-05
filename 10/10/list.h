#pragma once


struct ListElement;
struct List;
List* createList();
void push(List* list, int value); /// adds a list element with given value to the top
void addToTail(List* list, int value); /// adds a list element with given value to the tail
int getNumberOfElements(List* list);
ListElement *getHead(List *list);
int getHeadValue(List* list);
bool isEmpty(List* list);
void printList(List* list);
void deleteListElementFromTheTop(List *list);
void deleteList(List* list);
