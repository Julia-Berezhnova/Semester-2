#include <iostream>
#include <math.h>

using namespace std;

int involution(int number, int power)
{
	int temp = 0;
	if (power == 0)
	{
		return 1;
	}
	else if (power == 1)
	{
		return number;
	}
	else if (power % 2 == 0)
	{
		temp = involution(number, power / 2);
		return temp * temp;
	}
	else
	{
		return number * involution (number, power - 1);
	}		
}

int main()
{
	cout << "Enter a number: ";
	int number = 0;
	cin >> number;
	cout << "Enter a power: ";
	int power = 0;
	cin >> power;
	if (power > 0)
	{
		cout << number << "^" << power << " = " << involution(number, power) << endl;
	}
	else
	{
		cout << number << "^" << power << " = 1/" << involution(number, -power) << endl;
	}
	return 0;
}
