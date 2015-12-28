#pragma once

#include <string>

struct ListElement;

struct List;

List *createList();

void addElement(List *list, std::string word);

ListElement *getHead(List *list);

std::string getWord(ListElement *element);

ListElement *getNextListElement(ListElement *element);

void deleteList(List *list);