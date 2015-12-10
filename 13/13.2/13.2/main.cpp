#include <iostream>
#include <cstdio>
#include <limits.h>

using namespace std;

const int maxSize = 1024;

int main()
{
	FILE * input = fopen("input.txt", "r");
	if (input == NULL)
	{
		cout << "file not found" << endl;
	}
	else
	{
		char c = {};
		int state = 0;
		char output[maxSize] = {};
		int size = 0;
		while (c != EOF)
		{
			c = getc(input);
			switch (state)
			{
			case 0:
				size = 0;
				if (c == '/')
				{
					state = 1;
					if (size < maxSize)
					{
						output[size] = c;
						++size;
					}
					else
					{
						exit(1);
					}
				}
				else
				{
					state = 0;
				}
				break;
			case 1:
				if (c == '*')
				{
					state = 2;
					if (size < maxSize)
					{
						output[size] = c;
						++size;
					}
					else
					{
						exit(1);
					}
				}
				else
				{
					state = 0;
				}
				break;
			case 2:
				if (c == '*')
				{
					state = 3;
					if (size < maxSize)
					{
						output[size] = c;
						++size;
					}
					else
					{
						exit(1);
					}
				}
				else
				{
					state = 2;
					if (size < maxSize)
					{
						output[size] = c;
						++size;
					}
					else
					{
						exit(1);
					}
				}
				break;
			case 3:
				if (c == '/')
				{
					state = 0;
					if (size < maxSize)
					{
						output[size] = c;
						++size;
					}
					else
					{
						exit(1);
					}
					cout << "comment: " << endl;
					for (int i = 0; i < size; ++i)
					{
						cout << output[i];
						output[i] = {};
					}
					cout << endl;
				}
				else
				{
					state = 2;
					output[size] = c;
					++size;
				}
				break;
			}
		}
		fclose(input);
	}
}



/// test 1
/// input
/// /*
/// */
/// t  */
/// output
/// /*
/// */

/// test 2
/// input
/// abraxadabra */ */
/// output

/// test 3
/// input
/// abraxadabra  /*  *   /  */
/// output
/// /*  *   /  */

/// test 4
/// input
/// hello /*  world * /
/// output