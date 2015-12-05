// Определение программы findRoger,
// которая сортирует массив с помощью программы qSort из "qSort.cpp" 
// и находит наиболее часто встречающийся элемент массива
// если таких несколько - выводит первый 

#include "findRoger.h"
#include "qSort.h"

int findRoger(int array[], int size)
{
	qSort(array, 0, size - 1);
	int max = 1;
	int now = 1;
	int maxIs = array[0];
	for (int i = 1; i < size; ++i)
	{
		if (array[i] == array[i - 1])
		{
			++now;
			if (now > max)
			{
				max = now;
				maxIs = array[i];
			}
		}
		else
		{
			now = 1;
		}
		
	}
	if (max > 1)
	{
		return maxIs;
	}
	else
	{
		return -1;
	}
}