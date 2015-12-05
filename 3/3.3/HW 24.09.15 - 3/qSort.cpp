// Определение программы быстрой сортировки

#include <iostream>

#include "qSort.h"

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
