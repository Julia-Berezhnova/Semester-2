#include "hash.h"
#include <iostream>
#include <string>
#include <fstream>

using namespace std;

int main()
{
	HashTable *hashTable = createHashTable();
	ifstream file("text.txt", ios::in);
	if (!file.is_open())
	{
		cout << "file is not found" << endl;
		return 1;
	}
	while (!file.eof())
	{
		string word;
		file >> word;
		add(hashTable, word);
	}
	file.close();
	countWords(hashTable);
	deleteHashTable(hashTable);
	return 0;
}