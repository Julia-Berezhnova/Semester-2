#include "tree.h"
#include <iostream>
#include <string>

struct Node
{
	std::string data;
	Node* child[2]; //child[0] - left child, child[1] - right child
};

struct Tree
{
	Node *root;
};

//Creates structure Tree
Tree *createTree()
{
	Tree *result = new Tree;
	result->root = nullptr;
	return result;
}

//Creates a node 
Node *createNode(std::string value)
{
	Node *newNode = new Node;
	newNode->data = value;
	newNode->child[0] = nullptr;
	newNode->child[1] = nullptr;
	return newNode;
}

//Checks is value is one of four arithmetical operations
bool isOperation(std::string value)
{
	return (value == "+" || value == "-" || value == "*" || value == "/");
}

//Adds element to the subtree (tree with a root named pointer)
void addElement(Tree* tree, Node* node, Node* pointer, bool& isAdded)
{
	if (!isAdded)
	{
		if (pointer->child[0] == nullptr)
		{
			pointer->child[0] = node;
			isAdded = true;
			return;
		}
		if (isOperation(pointer->child[0]->data))
		{
			addElement(tree, node, pointer->child[0], isAdded);
		}
	}
	if (!isAdded)
	{
		if (pointer->child[1] == nullptr)
		{
			pointer->child[1] = node;
			isAdded = true;
			return;
		}
		if (isOperation(pointer->child[1]->data))
		{
			addElement(tree, node, pointer->child[1], isAdded);
		}
	}
}

//Adds new element to the tree
void addValue(Tree* tree, std::string value)
{
	Node* newNode = createNode(value);
	if (tree->root == nullptr)
	{
		tree->root = newNode;
		return;
	}
	bool isAdded = false;
	addElement(tree, newNode, tree->root, isAdded);
}

//Executes an infix traverse
//Prints tree elements
void traverse(Node *node)
{
	if (node != nullptr)
	{
		traverse(node->child[0]);
		std::cout << node->data << " ";
		traverse(node->child[1]);
	}
}

void printTree(Tree *tree)
{
	if (tree->root == nullptr)
	{
		std::cout << "The tree is empty";
		return;
	} 
	int branches = 0;
	traverse(tree->root);
	std::cout << std::endl;
}

int countSubTree(Node* node)
{
	if (node->data == "+")
	{
		return countSubTree(node->child[0]) + countSubTree(node->child[1]);
	}
	if (node->data == "-")
	{
		return countSubTree(node->child[0]) - countSubTree(node->child[1]);
	}
	if (node->data == "*")
	{
		return countSubTree(node->child[0]) * countSubTree(node->child[1]);
	}
	if (node->data == "/")
	{
		return countSubTree(node->child[0]) / countSubTree(node->child[1]);
	}
	return std::stoi(node->data);
}

int countTree(Tree* tree)
{
	return countSubTree(tree->root);
}

//Deletes subtree (tree with a root named node)
void deleteNode(Node* node)
{
	if (node->child[0] != nullptr)
	{
		deleteNode(node->child[0]);
	}
	if (node->child[1] != nullptr)
	{
		deleteNode(node->child[1]);
	}
	delete node;
}

void deleteTree(Tree* tree)
{
	if (tree->root != nullptr)
	{
		deleteNode(tree->root);
	}
}