#pragma once
#include "list.h"
#include <string>

struct HashTable;

HashTable *createHashTable();

int hashFunction(std::string const &word);

void add(HashTable *hashTable, std::string const &word);

void countWords(HashTable *hashTable);

void deleteHashTable(HashTable *hashTable);