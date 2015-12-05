#include "tree.h"
#include <iostream>
#include <string>
#include <fstream>

using namespace std;

int main()
{
	ifstream input("input.txt", ios::in);
	if (!input.is_open())
	{
		cout << "file not found" << endl;
		return 1;
	}
	string value = {};
	Tree* tree = createTree();
	while (!input.eof())
	{	
		input >> value;
		if (value.length() == 2)
		{
			if (value[0] == '(')
			{
				value = value[1];
			}
			if (value[1] == ')')
			{
				value = value[0];
			}
		}
		addValue(tree, value);
	}
	input.close();
	printTree(tree);
	cout << countTree(tree) << endl;
	deleteTree(tree);
	return 0;
}