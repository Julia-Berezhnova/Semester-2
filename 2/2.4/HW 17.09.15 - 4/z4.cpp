#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;

int main()
{
	cout << "Enter a size of array: ";
	int size = 0;
	cin >> size;
	int array[40] = {};

	if (size > 40)
	{
		cout << "Enter a smaller size, please: ";
		cin >> size;
		cout << "(It's for your own good)" << endl;
	}
	cout << "Initial array: " << endl;
	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		array[i] = rand() % 10;
		cout << array[i] << " ";
	}
	cout << endl;
	int placeForChange = 1;
	for (int i = size; i > 0; --i)
	{
		if (array[i] >= array[0])
		{
			placeForChange = i;
		}
	}

	int theOne = array[0];
	int numberOfTheOnes = 1;
	for (int i = 1; i < size; ++i)
	{
		if (array[i] < theOne && i > placeForChange)
		{
			swap(array[i], array[placeForChange]);
			++placeForChange;
		}
	}
	--placeForChange;
	
	for (int i = 1; i <= placeForChange; ++i)
	{
		array[i - 1] = array[i];
	}
	array[placeForChange] = theOne;
	
	int placeForChange2 = 1;
	for (int i = size; i > placeForChange; --i)
	{
		if (array[i] > array[0])
		{
			placeForChange2 = i;
		}
	}
	for (int i = placeForChange + 1; i < size; ++i)
	{
		if (array[i] == theOne)
		{
			swap(array[i], array[placeForChange2]);
			++placeForChange2;
		}
	}

	cout << "Sorted array: " << endl;
	for (int i = 0; i < size; ++i)
	{
		cout << array[i] << " ";
	}
	return 0;
}