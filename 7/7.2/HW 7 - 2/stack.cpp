#include "stack.h"
#include <iostream>

using namespace std;

struct Stack
{
	double array[maxSize];
	int size;
};

Stack *createStack()
{
	Stack *newStack = new Stack;
	newStack->size = 0;
	return newStack;
}

///Adds new value to the end of the stack array.
void push(double newElement, Stack *stack)
{
	stack->array[stack->size] = newElement;
	++stack->size;
}

///Returns value of the end of the stack array,
///then deletes it.
double pop(Stack *stack)
{
	--stack->size;
	return stack->array[stack->size];
}

///Adds two values on top of the stack,
///places result back on stack.
void add(Stack *stack)
{
	double first = pop(stack);
	double second = pop(stack);
	push(second + first, stack);
}

///Subtracks two values on top of the stack,
///places result back on stack.
void subtract(Stack *stack)
{
	double first = pop(stack);
	double second = pop(stack);
	push(second - first, stack);
}

///Multiplies two values on top of the stack,
///places result back on stack.
void multiply(Stack *stack)
{
	double first = pop(stack);
	double second = pop(stack);
	push(second * first, stack);
}

///Divides two values on top of the stack,
///places result back on stack.
void divide(Stack *stack)
{
	double first = pop(stack);
	double second = pop(stack);
	push(second / first, stack);
}