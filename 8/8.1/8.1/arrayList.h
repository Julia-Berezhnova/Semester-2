#pragma once

const int maxNumberOfElements = 100;

struct ArrayList;

/// ArrayList* createList();

void push(ArrayList* list, int value);

int pop(ArrayList* list);

int getElementsNumber(ArrayList* list);

int getHeadValue(ArrayList* list);

void deleteList(ArrayList* list);

ArrayList* reverseList(ArrayList* list);

void printList(ArrayList* list);