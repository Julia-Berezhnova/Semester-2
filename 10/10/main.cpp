#include "graph.h"
#include "countries.h"

#include <fstream>
#include <iostream>

using namespace std;

int main()
{
	ifstream file("input.txt", ios::in);
	if (!file.is_open())
	{
		cout << "file not found" << endl;
		return 1;
	}
	int	citiesNumber = 0;
	int roadsNumber = 0;
	int capitalsNumber = 0;
	file >> citiesNumber; 
	Graph* graph = createGraph(citiesNumber);
	file >> roadsNumber; 
	for (int i = 0; i < roadsNumber; ++i)
	{
		int vertex1 = 0;
		int vertex2 = 0;
		int roadLength = 0;
		file >> vertex1; 
		file >> vertex2;
		file >> roadLength;
		setWeight(graph, vertex1, vertex2, roadLength);
	}
	file >> capitalsNumber; 
	ArrayOfLists* countries = createArrayOfLists(capitalsNumber);
	for (int i = 0; i < capitalsNumber; ++i)
	{
		int capital = 0;
		file >> capital; 
		addNewCapital(countries, capital);
	}
	createCountries(countries, graph);
	printArrayOfLists(countries);
	deleteArrayOfLists(countries);
	deleteGraph(graph);
	file.close();
	return 0;
}

/// test 1
//5
//9
//1 2 7
//1 3 2
//1 4 3
//1 5 1
//2 3 9
//2 4 4
//2 5 5
//3 5 6
//4 5 8
//2
//1 2
/// answer
/// country with capital 1: 1 3 5
/// country with capital 2: 2 4

/// test 2
//5
//10
//1 2 7
//1 3 2
//1 4 3
//1 5 1
//2 3 9
//2 4 4
//2 5 5
//3 5 6
//4 5 8
//3 4 12
//3
//2 4 5
/// answer
/// country with capital 2: 2 1
/// country with capital 4: 4 3
/// country with capital 5: 5