#include "graph.h"

#include <iostream>

struct Graph
{
	int ** array;
	int vertexNumber;
};

Graph* createGraph(int vertexNumber)
{
	Graph *graph = new Graph;
	graph->array = new int*[vertexNumber];
	for (int i = 0; i < vertexNumber; ++i)
	{
		graph->array[i] = new int[vertexNumber];
	}
	for (int i = 0; i < vertexNumber; ++i)
	{
		for (int j = 0; j < vertexNumber; ++j)
		{
			graph->array[i][j] = 0;
		}
	}
	graph->vertexNumber = vertexNumber;
	return graph;
}

void setWeight(Graph* graph, int vertex1, int vertex2, int weight)
{
	graph->array[vertex1][vertex2] = weight;
	graph->array[vertex2][vertex1] = weight;
}

int getWeight(Graph* graph, int vertex1, int vertex2)
{
	return graph->array[vertex1][vertex2];
}

bool hasEdge(Graph* graph, int vertex1, int vertex2)
{
	return graph->array[vertex1][vertex2] != 0;
}

int getVertexNumber(Graph* graph)
{
	return graph->vertexNumber;
}

void deleteGraph(Graph* graph)
{
	for (int i = 0; i < graph->vertexNumber; ++i)
	{
		delete[] graph->array[i];
	}
	delete[] graph->array;
}

void printGraph(Graph* graph)
{
	for (int i = 0; i < graph->vertexNumber; ++i)
	{
		for (int j = 0; j < graph->vertexNumber; ++j)
		{
			std::cout << graph->array[i][j] << " ";
		}
		std::cout << std::endl;
	}
}