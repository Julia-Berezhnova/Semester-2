#pragma once

struct Graph;

Graph* createGraph(int vertexNumber);

void setWeight(Graph* graph, int vertex1, int vertex2, int weight);

int getWeight(Graph* graph, int vertex1, int vertex2);

bool hasEdge(Graph* graph, int vertex1, int vertex2);

int getVertexNumber(Graph* graph);

void printGraph(Graph* graph);

void deleteGraph(Graph* graph);