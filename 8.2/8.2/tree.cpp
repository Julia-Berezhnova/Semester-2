#include "tree.h"
#include <iostream>

struct Node
{
	int data;
	Node *child[2]; //child[0] - left child, child[1] - right child
};

struct Tree
{
	Node *root;
};

//Creates structure Tree
Tree *createTree()
{
	Tree *newTree = new Tree;
	newTree->root = nullptr;
	return newTree;
}

//Checks if there is a node with entered number
bool belongs(Tree *tree, int number)
{
	Node *temp = tree->root;
	while (temp != nullptr)
	{
		if (temp->data == number)
		{
			return true;
		}
		if (number < temp->data)
		{
			temp = temp->child[0];
		}
		else
		{
			temp = temp->child[1];
		}
	}
	return false;
}


//This is an accessory function for addNumber procedure
//Creates a node with entered number
Node *createNode(int number)
{
	Node *newNode = new Node;
	newNode->data = number;
	newNode->child[0] = nullptr;
	newNode->child[1] = nullptr;
	return newNode;
}


//Inserts new node with entered number
//If such node already exists, returns a mistake
//Otherwise returns 1
int addNumber(Tree* tree, int number)
{
	if (tree->root == nullptr)
	{
		tree->root = createNode(number);
		return 1;
	}
	Node *temp = tree->root;
	while (true)
	{
		if (temp->data == number)
		{
			return 0;
		}
		if (number < temp->data)
		{
			if (temp->child[0] == nullptr)
			{
				temp->child[0] = createNode(number);
				break;
			}
			temp = temp->child[0];
		}
		else
		{
			if (temp->child[1] == nullptr)
			{
				temp->child[1] = createNode(number);
				break;
			}
			temp = temp->child[1];
		}
	}
	return 1;
}

//Deletes a node which contains entered number
//If there is no such node, returns a mistake
//Otherwise returns 1
int deleteNumber(Tree* tree, int number)
{
	if (tree->root == nullptr)
	{
		return 0;
	}
	Node *temp = tree->root;
	Node *parent = nullptr;
	Node *next = nullptr;
	while (true) //we're going to find where value is situated ("temp") and what is his parent ("parent")
	{
		if (temp == nullptr)
		{
			return 0;
		}
		if (temp->data == number)
		{
			break;
		}
		else if (number < temp->data)
		{
			parent = temp;
			temp = temp->child[0];
		}
		else
		{
			parent = temp;
			temp = temp->child[1];
		}
	}
	if (temp->child[0] != nullptr && temp->child[1] != nullptr) 
	{
		parent = temp;
		next = temp->child[1];
		while (next->child[0] != nullptr)
		{
			parent = next;
			next = next->child[0];
		}
		temp->data = next->data;
		parent->child[parent->child[1] == next] = next->child[1];
		delete next;
	}
	else
	{
		if (parent == nullptr)
		{
			if (temp->child[0] == nullptr)
			{
				tree->root = temp->child[1];
			}
			else
			{
				tree->root = temp->child[0];
			}
		}
		if (parent->child[1] == temp)
		{
			if (temp->child[0] == nullptr)
			{
				parent->child[1] = temp->child[1];
			}
			else
			{
				parent->child[1] = temp->child[0];
			}
		}
		else
		{
			if (temp->child[0] == nullptr)
			{
				parent->child[0] = temp->child[1];
			}
			else
			{
				parent->child[0] = temp->child[0];
			}
		}
		delete temp;
	}
	return 1;
}


//Executes an infix traverse
void traverse(Node *node, int way)
{
	if (node != nullptr)
	{
		if (way == 1)
		{
			traverse(node->child[0], way);
			std::cout << node->data << " ";
			traverse(node->child[1], way);
		}
		else
		{
			traverse(node->child[1], way);
			std::cout << node->data << " ";
			traverse(node->child[0], way);
		}
	}
}

void printTree(Tree *tree, int way)
{
	if (tree->root == nullptr)
	{
		std::cout << "The tree is empty";
		return;
	}
	traverse(tree->root, way);
}


