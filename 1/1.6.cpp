#include <stdio.h>



int main()

{
    	
	int array[ 28 ] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};		
	for (int i = 0; i <= 9; ++i)
		
		{
			
			for (int j = 0; j <= 9; ++j)
			
			{
				
				for (int k = 0; k <= 9; ++k)
					{
						++array [i + j + k];
					}             
			}
		
		}
		

	int result = 0;
	
	for (int i = 0; i <= 27; ++i)
	{
		result = result + array[ i ] * array[ i ]; 
	}
	printf("Number of lucky tickets: %d.\n", result);
	
	scanf("%*s");
	
	return 0;

}