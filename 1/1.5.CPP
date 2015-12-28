#include <stdio.h>

int main()
{
    int m, n;
    int a[1000];
    printf("Enter m: ");
    scanf("%d", &m);
    printf("Enter n: ");
    scanf("%d", &n);
    if (m > 0 && n > 0)
    {
	for (int i = 0; i < n + m; ++i)
	{
	    printf("Enter a[ %d ]: ", i + 1);
	    scanf("%d", &a[ i ]);
	}
	for (int j = 0; j < m/2; ++j)
	{
	    int temp1 = a[ j ];
	    a[ j ] = a[ m - j - 1];
	    a[ m - j - 1] = temp1;
	}
	for (int k = m; k < m + n/2; ++k)
	{
	    int temp2 = a[ k ];
	    a[ k ] = a[ n - k - 1 + 2 * m ];
	    a[ n - k - 1 + 2 * m ] = temp2;
	}
	for (int t = 0; t < (m + n) / 2; ++t)
	    {
		int temp3 = a[ t ];
		a[ t ] = a[ m + n - t - 1 ];
		a[ m + n - t - 1] = temp3;
	    }
	printf("That's what you need: \n");
	for (int q = 0; q < m + n; ++q)
	{
		printf("%d ", a[ q ]);
	}
    }
    else
    {
	printf("It's not fun");
    }
    scanf("%*s");
    return 0;
}