#include <stdio.h>
#include <math.h>
#include <stdlib.h>

void main()
{
    int x,sqrx;
    printf("Enter x: ");
    scanf("%d",&x);
    sqrx=x*x;
    printf("x^4+x^3+x^2+x+1=%d",(sqrx+x)*(sqrx+1)+1);
}