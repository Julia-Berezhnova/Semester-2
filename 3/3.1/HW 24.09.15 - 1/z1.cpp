#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;

void insertSort(int array[], int left, int right)
{
	for (int i = left + 1; i < right; ++i)
	{
		int temp = array[i];
		for (int j = i - 1; j >= 0 && array[j] > temp; --j)
		{
			array[j + 1] = array[j];
			array[j] = temp;
		}
	}
}

void qSort(int array[], int left, int right)
{
	int start = left;
	int end = right;
	int key = array[(left + right) / 2];
	if (right - left < 11)
	{
		insertSort(array, left, right + 1);
	}
	else
	{
		while (left <= right)
		{
			while (array[left] < key)
			{
				++left;
			}
			while (array[right] > key)
			{
				--right;
			}
			if (left <= right)
			{
				swap(array[left], array[right]);
				++left;
				--right;
			}
		}
		if (left < end)
		{
			qSort(array, left, end);
		}
		if (right > start)
		{
			qSort(array, start, right);
		}
	}
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
	srand(time(nullptr));
	for (int i = 0; i < size; i++)
	{
		array[i] = rand() % 100;
		cout << array[i] << " ";
	}
	cout << endl;

	qSort(array, 0, size - 1);

	cout << "Sorted array: " << endl;
	for (int i = 0; i < size; i++)
	{
		cout << array[i] << " ";
	}
	return 0;
}