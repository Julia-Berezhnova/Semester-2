#include "binaryOperations.h"
 
// Модуль с реализацией следующих функций:
// 1. binaryRepresentation    - перевод в доп.двоичный код
// 2. binarySum               - вычисление суммы двух чисел в доп.двоичном коде
// 3. DecimalRepresentation   - десятичное представление числа в доп.двоичном коде


// 1. Функция меняет массив так, 
// чтобы он представлял собой дополнительный двоичный код числа
// только наоборот :) То есть 
// его надо выводить с конца к началу...
void binaryRepresentation(int number, bool binaryNumber[])
{
	for (int i = length - 1; i >= 0; --i)
	{
		int mask = 1 << i; // mask = маска. используем метод побитового сдвига  
		binaryNumber[i] = (number & mask) != 0; // применяем поразрядное умножение
	}
}

// 2. Функция вычисляет сумму двух чисел,
// представленных в дополнительном двоичном коде
// Сумма тоже в дополнительном двоичном коде
void binarySum(bool number1[], bool number2[], bool result[])
{
	bool mind = false; // флажок "единица в уме". изначально в уме ничего нет 
	for (int i = 0; i <= length - 1; ++i)
	{
		result[i] = number1[i] ^ number2[i];
		if (number1[i] && number2[i] && !mind)
		{
			result[i] = 0;
			mind = true;
		}
		else if (mind && !number1[i] && !number2[i])
		{
			result[i] = 1;
			mind = false;
		}
		else if (mind && result[i])
		{
			result[i] = 0;
			mind = true;
		}
		else if (mind && number1[i] && number2[i])
		{
			result[i] = 1;
			mind = true;
		}
	}
}

// 3. Функция возвращает десятичное представление числа,
// представленного в дополнительном двоичном коде
double DecimalRepresentation(bool number[])
{
	double result = 0;
	int powOfTwo = 1;
	if (!number[length - 1])
	{
		for (int i = 0; i < length; ++i)
		{
			result = result + number[i] * powOfTwo;
			powOfTwo = powOfTwo * 2;
		}
	}
	else
	{
		for (int i = 0; i < length; ++i)
		{
			result = result + (!number[i]) * powOfTwo;
			powOfTwo = powOfTwo * 2;
		}
		++result;
		result = -result;
	}
	return result;
}