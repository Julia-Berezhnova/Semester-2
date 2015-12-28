#include <stdio.h>

#include <stdlib.h>

#include <time.h>



int main()

{
    
	int numNull = 0;
    
	srand(time(NULL));
    
	for (int i = 0; i < 13; ++i)
    
	{
        
		int number = rand();
	
        printf("Element %d of array: %d.\n", i + 1, number);

	        if (number == 0)
	
        {
            
			++numNull;
        
		}
    
	}
    
	printf("Number of NULL-elements: %d.\n", numNull);
    
	scanf("%*s");
    
	return 0;

}

