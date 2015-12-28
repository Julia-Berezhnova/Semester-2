#include "insertSort.h"

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