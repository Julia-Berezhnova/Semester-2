#include "mergeSort.h"

///Returns new sorted list which consists of two given lists
List* merge(List* firstList, List* secondList)
{
	firstList = reverseList(firstList);
	secondList = reverseList(secondList);
	List* result = createList();
	int resultSize = getElementsNumber(firstList) + getElementsNumber(secondList);
	for (short i = 0; i < resultSize; ++i)
	{
		if (getElementsNumber(firstList) > 0 && getElementsNumber(secondList) > 0)
		{
			if (getHeadValue(firstList) > getHeadValue(secondList))
			{
				push(result, pop(firstList));
			}
			else
			{
				push(result, pop(secondList));
			}
		}
		else if (getElementsNumber(firstList) > 0)
		{
			push(result, pop(firstList));
		}
		else
		{
			push(result, pop(secondList));
		}
	}
	deleteList(firstList);
	deleteList(secondList);
	return result;
}

///Returns a sorted list
List *mergeSort(List *list)
{
	if (getElementsNumber(list) > 1)
	{
		short halfOfSize = getElementsNumber(list) / 2;
		List *secondList = createList();
		while (getElementsNumber(list) > halfOfSize)
		{
			push(secondList, pop(list));
		}
		list = merge(mergeSort(list), mergeSort(secondList));
	}
	return list;
}
