#include <stdio.h>
#include <math.h>
#include <stdlib.h>

int quotient(int firstNum, int secondNum)
{
    int result = 0;
    while (firstNum >= secondNum)
    {
	firstNum -= secondNum;
	++result;
    }
    return result;
}

void main()
{
    int firstNum, secondNum, result;
    printf("Enter first number: ");
    scanf("%d", &firstNum);
    printf("Enter second number: ");
    scanf("%d", &secondNum);
    if (firstNum < 0 && secondNum > 0)
    {
	firstNum = abs(firstNum);
	result = (-1)*(quotient(firstNum, secondNum) + 1);
    }
    else
    {
	if (firstNum > 0 && secondNum < 0)
	{
	    secondNum = abs(secondNum);
	    result = (-1) * quotient(firstNum, secondNum);
	}
	else
	{
	    if (firstNum < 0 && secondNum < 0)
	    {
		firstNum = abs(firstNum);
		secondNum = abs(secondNum);
		result = quotient(firstNum, secondNum) + 1;
	    }
	    else
	    {
		if (secondNum != 0)
		{
		    result = quotient(firstNum, secondNum);
		}
	    }
	}
    }
    if (secondNum != 0)
    {
	printf("Quotient of %d to %d is %d", firstNum, secondNum, result);
    }
    else
    {
	printf("Dividing by zero is forbidden by God");
    }
}
