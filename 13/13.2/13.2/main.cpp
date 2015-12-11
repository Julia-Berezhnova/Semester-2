#include <iostream>
#include <cstdio>
using namespace std;

const int maxSize = 1024;

int main()
{
	FILE * input = fopen("input.txt", "r");
	if (input == NULL)
	{
		cout << "file not found" << endl;
		return 1;
	}
	char c = {};
	int state = 0;
	char output[maxSize] = {};
	int size = 0;
	int table[3][4] = 
	{
		/// state 0 state 1 state 2 state 3 
				1,    1,      2,       0,	/// /
				0,	  2,	  3,       3,	/// *
				0,	  0,	  2,	   2	/// other 	
	};
	while (c != EOF)
	{
		c = getc(input);
		int previousState = state;
		if (c == '/')
		{
			state = table[0][state];
		}
		else if (c == '*')
		{
			state = table[1][state];
		}
		else
		{
			state = table[2][state];
		}
		if (previousState == 3 && state == 0)
		{
			for (int i = 0; i < size; ++i)
			{
				cout << output[i];
				output[i] = {};
			}
			cout << '/' << endl;
			size = 0;
		}
		if (state == 2)
		{
			if (previousState == 1)
			{
				if (size < maxSize)
				{
					output[size] = '/';
					++size;
				}
				else
				{
					exit(1);
				}
			}
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
		if (state == 3)
		{
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
	}
	fclose(input);
	return 0;
}



//int main()
//{
//	FILE * input = fopen("input.txt", "r");
//	if (input == NULL)
//	{
//		cout << "file not found" << endl;
//	}
//	else
//	{
//		char c = {};
//		int state = 0;
//		char output[maxSize] = {};
//		int size = 0;
//		while (c != EOF)
//		{
//			c = getc(input);
//			switch (state)
//			{
//			case 0:
//				size = 0;
//				if (c == '/')
//				{
//					state = 1;
//					if (size < maxSize)
//					{
//						output[size] = c;
//						++size;
//					}
//					else
//					{
//						exit(1);
//					}
//				}
//				else
//				{
//					state = 0;
//				}
//				break;
//			case 1:
//				if (c == '*')
//				{
//					state = 2;
//					if (size < maxSize)
//					{
//						output[size] = c;
//						++size;
//					}
//					else
//					{
//						exit(1);
//					}
//				}
//				else
//				{
//					state = 0;
//				}
//				break;
//			case 2:
//				if (c == '*')
//				{
//					state = 3;
//					if (size < maxSize)
//					{
//						output[size] = c;
//						++size;
//					}
//					else
//					{
//						exit(1);
//					}
//				}
//				else
//				{
//					state = 2;
//					if (size < maxSize)
//					{
//						output[size] = c;
//						++size;
//					}
//					else
//					{
//						exit(1);
//					}
//				}
//				break;
//			case 3:
//				if (c == '/')
//				{
//					state = 0;
//					if (size < maxSize)
//					{
//						output[size] = c;
//						++size;
//					}
//					else
//					{
//						exit(1);
//					}
//					for (int i = 0; i < size; ++i)
//					{
//						cout << output[i];
//						output[i] = {};
//					}
//					cout << endl;
//				}
//				else
//				{
//					state = 2;
//					output[size] = c;
//					++size;
//				}
//				break;
//			}
//		}
//		fclose(input);
//	}
//}



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
/// abrakadabra */ */
/// output

/// test 3
/// input
/// abrakadabra  /*  *   /  */
/// output
/// /*  *   /  */

/// test 4
/// input
/// hello /*  world * /
/// output