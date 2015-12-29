#pragma once

struct ListElement;
struct List;

List* createList(int size);
int survivor(List* list, int m);
void deleteElement(int x, List* list);