#pragma once
#include <string>

struct Node;
struct Tree;
Tree* createTree();
bool isOperation(std::string value);
void addElement(Tree* tree, Node* node, Node* pointer, bool& isAdded);
void addValue(Tree* tree, std::string value);
void traverse(Node* node);
void printTree(Tree* tree);
int countSubTree(Node* node);
int countTree(Tree* tree);
void deleteNode(Node* node);
void deleteTree(Tree* tree);