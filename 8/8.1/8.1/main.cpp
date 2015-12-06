#include <iostream>
#include <fstream>

#include "mergeSort.h"
#include "arrayList.h"
#include "pointerList.h"

using namespace std;

int main()
{
	typedef PointerList List;
	/// typedef ArrayList List; 
	ifstream file("input.txt", ios::in);
	if (!file.is_open())
	{
		cout << "file not found" << endl;
		return 1;
	}
	List* list = createList();
	while (!file.eof())
	{
		int value = 0;
		file >> value;
		push(list, value);
	}
	file.close();
	list = mergeSort(list);
	printList(list);
	deleteList(list);
	return 0;
}