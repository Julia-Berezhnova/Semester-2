#include <stdio.h>

/*
int fibonacci (int number)
{
	if (number == 1 || number == 2)
		return 1;
	else
		return fibonacci (number - 1) + fibonacci (number - 2);
}

int main()
{
	int number = 0;
	printf ("Enter a positive number: ");
	scanf ("%d", &number);
	if (number > 0)
		printf ("The number #%d in Fibonacci sequence is %d.\n", number, fibonacci (number));
	else
		printf ("Don't play the fool.\n");
	scanf ("%*s");
	return 0;
}

*/

/*

int main()
{
	int number = 0;
	printf ("Enter a positive number: ");
	scanf ("%d", &number);
	int prevNum = 1;
	int prevPrevNum = 0;
	int numberNow = 1;
	if (number > 0)
	{
		for (int i = 1; i < number; ++i)
		{
			numberNow = prevNum + prevPrevNum;
			prevPrevNum = prevNum;
			prevNum = numberNow;
		}
		printf ("The number #%d in Fibonacci sequence is %d.\n", number, numberNow);
	}
	else
		printf ("Don't play the fool.\n");
	scanf ("%*s");
	return 0;
}
*/