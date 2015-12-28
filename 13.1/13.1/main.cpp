#include <iostream>
#include <cstdio>

using namespace std;

int main()
{
	FILE * input = fopen("input.txt", "r");
	char c = 'a';
	int state = 0;
	if (input == NULL)
	{
		cout << "file not found" << endl;
	}
	else
	{
		while (true)
		{
			c = getc(input);
			switch (state)
			{
			case 0:
				if (c == ' ' || c == '\n' || c == '\t')
				{
					state = 0;
				}
				else if (c >= '0' && c <= '9')
				{
					state = 1;
				}
				else
				{
					state = -1;
				}
				break;
			case 1:
				if (c >= '0' && c <= '9')
				{
					state = 1;
				}
				else if (c == '.' || c == ',')
				{
					state = 2;
				}
				else if (c == EOF || c == ' ' || c == '\n' || c == '\t')
				{
					cout << "This is a real number" << endl;
					exit(0);
				}
				else
				{
					state = -1;
				}
				break;
			case 2:
				if (c >= '0' && c <= '9')
				{
					state = 3;
				}
				else
				{
					state = -1;
				}
				break;
			case 3:
				if (c >= '0' && c <= '9')
				{
					state = 3;
				}
				else if (c == EOF || c == ' ' || c == '\n' || c == '\t')
				{
					cout << "This is a real number" << endl;
					exit(0);
				}
				else if (c == 'E')
				{
					state = 4;
				}
				else
				{
					state = -1;
				}
				break;
			case 4:
				if (c >= '0' && c <= '9')
				{
					state = 6;
				}
				else if (c == '-' || c == '+')
				{
					state = 5;
				}
				else
				{
					state = -1;
				}
				break;
			case 5:
				if (c >= '0' && c <= '9')
				{
					state = 6;
				}
				else
				{
					state = -1;
				}
				break;
			case 6:
				if (c >= '0' && c <= '9')
				{
					state = 6;
				}
				else if (c == EOF || c == ' ' || c == '\n' || c == '\t')
				{
					cout << "This is a real number" << endl;
					exit(0);
				}
				break;
			case -1:
				cout << "This is not a real number" << endl;
				exit(1);
				break;
			}
		}
		fclose(input);
	}
}

/// test 1
/// input:	3.01E9
/// output: This is a real number

/// test 2
/// input:			12		

/// output: This is a real number

/// test 3
/// input:  01.05E-4 	
/// output: This is a real number

/// test 4
/// input:  01.05E- 	
/// output: This is not a real number

/// test 5
/// input:  129.347E+12934	
/// output: This is a real number