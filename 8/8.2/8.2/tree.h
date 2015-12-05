#pragma once

struct Node;
struct Tree;
Tree *createTree();
bool belongs(Tree *tree, int number);
int addNumber(Tree* tree, int number);
int deleteNumber(Tree* tree, int number);
void printTree(Tree *tree, int way);
