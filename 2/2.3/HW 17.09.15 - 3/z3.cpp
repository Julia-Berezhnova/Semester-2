#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;

int bubbleSort(int array[], int size)
{
	for (int i = 0; i < size; ++i)
	{
		for (int j = size - 1; j > i; --j)
		{
			if (array[j] < array[j - 1])
			{
				swap(array[j], array[j - 1]);
			}
		}
	}
	return 0;
}

int countSort(int array[], int size)
{
	int counter[10] = {};
	for (int i = 0; i < size; ++i)
	{
		++counter[array[i]];
	}

	int k = 0;
	for (int i = 0; i < 10; ++i)
	{
		if (counter[i] != 0)
		{
			for (int j = 0; j < counter[i]; ++j)
			{
				array[k] = i;
				++k;
			}
		}
	}
	return 0;
}

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

	//bubbleSort(array, size);
	countSort(array, size);
	
	cout << "Sorted array: " << endl;
	for (int i = 0; i < size; i++)
	{
		cout << array[i] << " ";
	}
}

