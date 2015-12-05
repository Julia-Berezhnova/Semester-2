#include <stdio.h>
#include <math.h>

int primeNum(int number)
{
	if (number <= 1)
	{
		return 0;
	}
	for (int i = 2; i <= sqrt(number); ++i)
	{
		if (number % i == 0)
		{
			return 0;
		}
	}
	return 1;
}

int main()
{
	int a;
	printf("Enter number: ");
	scanf("%d",&a);

	if (a > 1)
	{
		printf("Simple numbers before %d: ",a);
		for (int j = 1; j < a + 1; ++j)
		{
			if (primeNum(j) == 1)
			{
				printf("%d ",j);
			}
		}
	}
	else
	{
		printf("No simple numbers before %d",a);
	}
	scanf("%*s");
	return 0;
}