#include <stdio.h>

int main()
{
	char string[1000];

	printf("Tell me something: \n");
	scanf("%s", &string);

	int check = 0;
	for (int i = 0; string[ i ] != '\0'; ++i)
	{
		if (string [ i ] == '(')
		{
			++check;
		}
		else
		{
			if (string [ i ] == ')' && check > 0)
			{
				--check;
			}
			else if (string [ i ] == ')' && check <= 0)
			{
				printf("Incorrect.\n");
				scanf("%*s");
				return 0;
			}
		}
	}
	if (check == 0)
	{
		printf("Everything is ok.\n");
	}
	else
	{
		printf("Incorrect.\n");
	}
	scanf("%*s");
	return 0;
}