#include "stack.h"

struct Stack
{
	char array[maxSize];
	int size;
};

Stack *createStack()
{
	Stack *newStack = new Stack;
	newStack->size = 0;
	for (int i = 0; i < maxSize; ++i)
	{
		newStack->array[i] = 0;
	}
	return newStack;
}

///Adds new value to the end of the stack array.
void push(char newElement, Stack *stack)
{
	stack->array[stack->size] = newElement;
	++stack->size;
}

///Returns value of the last element in the stack array,
///then deletes it.
char pop(Stack *stack)
{
	if (stack->size > 0)
	{
		--stack->size;
		return stack->array[stack->size];
	}
	return 0;
}

///Checks if stack is empty
bool isEmpty(Stack *stack)
{
	return (stack->size == 0);
}

void deleteStack(Stack *stack)
{
	delete[] stack->array;
}