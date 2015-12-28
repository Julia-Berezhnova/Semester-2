#pragma once
#include "countries.h"
#include <limits.h>
#include <iostream>

struct ArrayOfLists
{
	int capitalsNumber;
	List* array[maxNumberOfCapitals]; /// head of each list is a capital
};

ArrayOfLists* createArrayOfLists(int capitalsNumber)
{
	ArrayOfLists* arrayOfLists = new ArrayOfLists;
	for (int i = 0; i < maxNumberOfCapitals; ++i)
	{
		arrayOfLists->array[i] = createList();
	}
	arrayOfLists->capitalsNumber = capitalsNumber;
	return arrayOfLists;
}

/// takes an empty list and changes its head 
void addNewCapital(ArrayOfLists* arrayOfLists, int capital)
{
	for (int i = 0; i < arrayOfLists->capitalsNumber; ++i)
	{
		if (isEmpty(arrayOfLists->array[i]))
		{
			push(arrayOfLists->array[i], capital);
			return;
		}
	}
}

void createCountries(ArrayOfLists* countries, Graph* graph)
{
	int numberOfCities = getVertexNumber(graph);
	int numberOfFreeCities = numberOfCities - (countries->capitalsNumber); /// we will decrease this value 
	bool* freeCities = new bool[numberOfCities]; /// array of all cities. if 'false', then the city is linked to some country
	for (int i = 0; i < numberOfCities; ++i)
	{
		freeCities[i] = true; /// all cities are free - we haven't created countries yet
	}
	for (int i = 0; i < countries->capitalsNumber; ++i)
	{
		freeCities[getHeadValue(countries->array[i]) - 1] = false; /// capitals are linked to countries - they are not free
	}
	int i = 0; /// we are examining the first capital 
	while (numberOfFreeCities > 0)
	{
		int capital = getHeadValue(countries->array[i]);
		int shortestRoad = INT_MAX;
		for (int j = 1; j <= numberOfCities; ++j) /// examining all cities. current city is the city number 'j'
		{
			int road = getWeight(graph, capital, j);
			if (road < shortestRoad && hasEdge(graph, capital, j) && freeCities[j - 1] == true) /// looking for the closest city
				  /// which must have a road to the capital (and be not the same city)
				 	/// and must be	free				
			{
				shortestRoad = road;
				freeCities[j - 1] = false; /// this city is not free any more
				--numberOfFreeCities; /// decreasing number of unlinked cities
				addToTail(countries->array[i], j); /// adding the city to the country with given capital 
				break;
			}
		}
		++i; /// go to the next capital
		if (i == countries->capitalsNumber) /// if this is the last capital
		{
			i = 0; /// go the the first capital again
		}
	}
	delete[] freeCities; /// cleaning memory
}

/// prints our countries
void printArrayOfLists(ArrayOfLists* arrayOfLists)
{
	for (int i = 0; i < arrayOfLists->capitalsNumber; ++i)
	{
		std::cout << "Country number " << i + 1 << ": " << std::endl;
		std::cout << "(capital) ";
		printList(arrayOfLists->array[i]);
	}
}

void deleteArrayOfLists(ArrayOfLists* arrayOfLists)
{
	for (int i = 0; i < maxNumberOfCapitals; ++i)
	{
		deleteList(arrayOfLists->array[i]);
	}
	delete arrayOfLists;
}