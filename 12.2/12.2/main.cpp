#include "graph.h"
#include <iostream>
#include <fstream>

using namespace std;

Graph* primAlgorithm(Graph* graph)
{
	int vertexNumber = getVertexNumber(graph);
	Graph* result = createGraph(vertexNumber);
	bool* visited = new bool[vertexNumber];
	visited[0] = true;
	int numberOfVisited = 1;
	for (int i = 1; i < vertexNumber; ++i)
	{
		visited[i] = false;
	}
	while (numberOfVisited < vertexNumber)
	{
		int candidate = -1;
		int from = -1;
		int weight = -1;
		int min = INT_MAX;
		for (int i = 0; i < vertexNumber; ++i)  /// going through all visited vertices
		{
			if (visited[i])
			{
				for (int j = 0; j < vertexNumber; ++j)
				{
					if (!visited[j] && hasEdge(graph, i, j) && getWeight(graph, i, j) < min)
					{
						min = getWeight(graph, i, j);
						candidate = j;
						from = i;
						weight = min;
					}
				}
			}
		}
		setWeight(result, from, candidate, weight);
		visited[candidate] = true;
		visited[from] = true;
		++numberOfVisited;
	}
	delete[] visited;
	return result;
}

int main()
{
	ifstream file("input.txt", ios::in);
	if (!file.is_open())
	{
		cout << "file not found" << endl;
		return 1;
	}
	int vertexNumber = 0;
	while (!file.eof())
	{
		file >> vertexNumber;
		Graph* graph = createGraph(vertexNumber);
		for (int i = 0; i < vertexNumber; ++i)
		{
			for (int j = 0; j < vertexNumber; ++j)
			{
				int x = 0;
				file >> x;
				setWeight(graph, i, j, x);
			}
		}
		cout << "Minimum spanning tree: " << endl;
		Graph* result = primAlgorithm(graph);
		printGraph(result);
		deleteGraph(graph);
		deleteGraph(result);
	}
	file.close();
	return 0;
}

/// test 1
/// input
///5
///0 7 2 3 1
///7 0 9 0 6
///2 9 0 0 6
///3 4 0 0 8
///1 5 6 8 0
/// output
///0 0 2 3 1
///0 0 0 4 0
///2 0 0 0 0
///3 4 0 0 0
///1 0 0 0 0

/// test 2
/// input
///4
///0 1 5 15
///1 0 2 12
///5 2 0 6
///15 12 6 0
/// output
///0 1 0 0
///1 0 2 0
///0 2 0 6
///0 0 6 0

