#include <stdio.h>



int main()

{
   
	char mainStr[1000] = "";
   
	char subStr[1000] = "";

   
   
	printf("Enter string: ");
   
	scanf("%s", &mainStr);
   
	printf("Enter string you're looking for in the previous one: ");
   
	scanf("%s", &subStr);
   

	int lengthSubStr = 0;
   
	for (int i = 0; subStr[i] != '\0'; ++i)
   
	{
      
		lengthSubStr++;
   
	}
   
   
	
	int j = 0;
   
	int result = 0;
   

	for (int i = 0; mainStr [ i ] != '\0'; ++i)
   
	{
        
		if (mainStr [ i ] == subStr[ j ])
        
		{
              
			++j;
              
			if (j == lengthSubStr)
              
			{
                  
				j = 0;
                  
				result++;
              
			}
        
		}
        
		else 
        
		{
            
			j = 0;
        
		}
   
	}
   
	
	printf("'%s' is in '%s' %d times.\n",subStr,mainStr,result);
   

	scanf("%*s");
   	
	return 0;

}