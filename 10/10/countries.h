#pragma once
#include "graph.h"
#include "list.h"
const int maxNumberOfCapitals = 100;

struct ArrayOfLists;
ArrayOfLists* createArrayOfLists(int capitalsNumber);
void addNewCapital(ArrayOfLists* arrayOfLists, int capital);
void createCountries(ArrayOfLists* countries, Graph* graph);
void printArrayOfLists(ArrayOfLists* arrayOfLists);
void deleteArrayOfLists(ArrayOfLists* arrayOfLists);