#include "hash.h"
#include "list.h"

#include <string>
#include <iostream>

const int sizeOfHashTable = 100;
const int amountOfWords = 1024;

struct HashTable
{
	List *hashTable[sizeOfHashTable];
};

///Returns an empty hash table
HashTable *createHashTable()
{
	HashTable *hashTable = new HashTable;
	for (unsigned i = 0; i < sizeOfHashTable; ++i)
	{
		hashTable->hashTable[i] = createList();
	}
	return hashTable;
}

///Commits hash function
int hashFunction(std::string const &word)
{
	int hash = 0;
	for (unsigned i = 0; i < word.length(); ++i)
	{
		hash += word[i];
	}
	return hash % sizeOfHashTable;
}

///Adds new element into hash table
void add(HashTable *hashTable, std::string const &word)
{
	addElement(hashTable->hashTable[hashFunction(word)], word);
}

///Counts different words in hash table
void countWords(HashTable *hashTable)
{
	for (unsigned i = 0; i < sizeOfHashTable; ++i) ///cycle through hash table
	{
		if (getHead(hashTable->hashTable[i]) != nullptr)
		{
			std::string words[amountOfWords] = {}; ///array of different words
			int numbersOfWords[amountOfWords] = { 0 }; ///array of different words numbers
			int k = 0; ///in our situation 'k' is a counter for 'words' and 'numbersOfWords'
						///and at the same time it shows how many different words there are
			ListElement *temp = getHead(hashTable->hashTable[i]);
			while (temp != nullptr) ///cycle through the list
			{
				bool wordIsNew = true;
				std::string word = getWord(temp);
				for (unsigned j = 0; j < k; ++j)
				{
					if (word == words[j])
					{
						++numbersOfWords[j];
						wordIsNew = false;
						break;
					}
				}
				if (wordIsNew)
				{
					words[k] = word;
					++numbersOfWords[k];
					++k;
				}
				temp = getNextListElement(temp);
			}
			for (unsigned j = 0; j < k; ++j)
			{
				std::cout << words[j] << " " << numbersOfWords[j] << std::endl;
			}
		}
	}
}

///Deletes hash table
void deleteHashTable(HashTable *hashTable)
{
	for (unsigned i = 0; i < sizeOfHashTable; ++i)
	{
		deleteList(hashTable->hashTable[i]);
	}
	delete hashTable;
}