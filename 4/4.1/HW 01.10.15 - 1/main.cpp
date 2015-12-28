#include <iostream>
#include <locale.h>
#include "binaryOperations.h"

using namespace std;

// Фунцкия печати массива, в данном случае числа в двоичном представлении
void printBinaryNumber(bool binaryNumber[])
{
	cout << "Дополнительный двоичный код: " << endl;
	for (int i = length - 1; i >= 0; --i)
	{
		cout << binaryNumber[i] << " ";
	}
	cout << endl;
}


int main()
{
	setlocale(LC_ALL, "RUS");

	int number = 0;
	bool binaryNumber1[length] = {};
	cout << "Введите первое число: ";
	cin >> number;
	binaryRepresentation(number, binaryNumber1);
	printBinaryNumber(binaryNumber1);

	bool binaryNumber2[length] = {};
	cout << "Введите второе число: ";
	cin >> number;
	binaryRepresentation(number, binaryNumber2);
	printBinaryNumber(binaryNumber2);

	bool binaryNumber3[length] = {};
	cout << "Сумма. ";
	binarySum(binaryNumber1, binaryNumber2, binaryNumber3);
	printBinaryNumber(binaryNumber3);
	
	cout << "Десятичное представление суммы: " << endl;
	cout << DecimalRepresentation(binaryNumber3) << endl;
	
	return 0;
}

// Если ввести огромное число, то значения всех переменных равны нулю
// При вводе строки аналогично 