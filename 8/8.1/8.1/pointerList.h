#pragma once

struct PointerListElement;

struct PointerList;

PointerList* createList();

void push(PointerList* list, int value);

int pop(PointerList* list);

int getElementsNumber(PointerList* list);

int getHeadValue(PointerList* list);

void deleteList(PointerList* list);

PointerList* reverseList(PointerList* list);

void printList(PointerList* list);