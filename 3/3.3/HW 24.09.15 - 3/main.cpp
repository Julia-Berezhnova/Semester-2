// Программа считывает из файла "array.txt" массив чисел типа int
// и находит наиболее часто встречающийся там элемент 

#include <iostream>
#include <fstream>
#include <locale.h>

#include "qSort.h"
#include "findRoger.h"

using namespace std;


int main()
{
	setlocale(LC_ALL, "RUS");
	
	ifstream file("array.txt", ios::in);
	if (!file.is_open())
	{
		cout << "файл array.txt не найден" << endl;
		return 1;
	}

	int array[100] = {};
	int size = 0;

	while (!file.eof())
	{
		file >> array[size];
		++size;
	}

	int result = findRoger(array, size);
	if (result > -1)
	{
		cout << "Наиболее часто встречающийся элемент: " << result << endl;
	}
	else
	{
		cout << "Все элементы найдены единожды" << endl;
	}
	return 0;
}

//Ввела некорректные данные (строку). Ничего не делает. Просто висит окошко cmd.exe
//Ввела 1 44444444444444444444444444444 6666666666666666666666666666 777777777777777777777777777777777777777. Аналогично
//Ввела 22222222222222222222222222222222222222222222. "Все элементы найдены единожды"
//Если несколько элементов встречаются одинаково часто (и это максимум), то выдает первый такой элемент. Потому что в findRoger условие (now > max), т.е. знак строгий
//Задания 2.3 и 3.2 - это ведь то же самое, да? :)