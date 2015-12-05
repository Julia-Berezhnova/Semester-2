#include <iostream>
#include <time.h>
#include <cstdlib>

using namespace std;

bool binarySearch(int number, int array[], int left, int right)
{
	if (right < left)
	{
		return false;
	}
	if (array[(left + right) / 2] == number)
	{
		return true;
	}
	if (number < array[(left + right) / 2])
	{
		return binarySearch(number, array, left, (left + right) / 2 - 1);
	}
	else
	{
		return binarySearch(number, array, (left + right) / 2 + 1, right);
	}
}

void qSort(int array[], int left, int right)
{
	int start = left;
	int end = right;
	int key = array[(left + right) / 2];
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

int main()
{
	int size = 0;
	int num = 0;
	cout << "Enter size of array: ";
	cin >> size;
	cout << "Enter number of numbers: ";
	cin >> num;
	while (num < 1)
	{
		cout << "Number should be positive!" << endl;
		cout << "Enter number of numbers: ";
		cin >> num;
	}

	int array[5001] = {};
	srand(time(NULL));
	for (int i = 0; i < size; i++)
	{
		array[i] = rand();
	}
	
	qSort(array, 0, size - 1);
	for (int i = 0; i < num; ++i)
	{
		int number = rand();
		if (binarySearch(number, array, 0, size))
		{
			cout << "Array contains " << number << endl;
		}
		else
		{
			cout << "Array does not contain " << number << endl;
		}
	}
	return 0;
}
//Ввела размер 5000, количество 30 000. Программа честно работала около минуты. Без ошибок на выходе.
//6000, 32 000. Прекращена работа программы
//6000, 1 000. Прекращена работа программы
//0, 20. Выдал 20 строчек, отличающихся только числами :)
//-20, 60. Выдал 60 строчек, отличающихся только числами :)
//120, -80. Для продолжения нажмите любую клавишу...
//Ввела 'hello'. Для продолжения нажмите любую клавишу... 
//Дописала немного, чтобы "общаться" с пользователем. Только не знаю, как определить, соответствуют ли
//введенные данные нужному нам типу (то есть если вводится не число, а фигня какая-то) 