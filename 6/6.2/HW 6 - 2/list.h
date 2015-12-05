#pragma once

struct ListElement;
struct List;

List* createList();
void addElement(int x, List* list);
void deleteElement(int x, List* list);
void printList(List* list);
