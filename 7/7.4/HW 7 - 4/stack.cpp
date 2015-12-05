#include "stack.h"
#include <iostream>

struct StackElement
{
	char value;
	StackElement *next;
};

struct Stack
{
	StackElement *top;
};

//Creates and returns new stack element with needed data
StackElement *newElement(char symbol, StackElement *next)
{
	StackElement *newElement = new StackElement;
	newElement->next = next;
	newElement->value = symbol;
	return newElement;
}

//Adds new element to the stack
void add(char symbol, Stack *stack)
{
	StackElement *temp = newElement(symbol, stack->top->next);
	stack->top->next = temp;
}

Stack *createStack()
{
	Stack *newStack = new Stack;
	newStack->top = newElement(0, nullptr);
	return newStack;
}

bool isEmpty(Stack *stack)
{
	return stack->top->next == nullptr;
}

char pop(Stack *stack)
{
	char result = stack->top->next->value;
	StackElement *temp = stack->top->next;
	stack->top->next = stack->top->next->next;
	delete temp;
	return result;
}

//Deletes stack element
void deleteElement(Stack *stack)
{
	StackElement *temp = stack->top->next;
	stack->top->next = stack->top->next->next;
	delete temp;
}

//Deletes stack
void removeAll(Stack *stack)
{
	while (!isEmpty(stack))
	{
		deleteElement(stack);
		delete stack->top;
		delete stack;
	}
}

//Returns priority of operation
int priority(char c)
{
	switch (c)
	{
	case '*': return 3;
	case '/': return 3;
	case '-': return 2;
	case '+': return 2;
	case '(': return 1;
	}
}


//Converts an expression from infix to postfix notation
//and displays the result
void count(char entered[], int length)
{
	Stack *operations = createStack();
	int dynamicLength = 0;
	char *rendered = new char[dynamicLength];
	
	int j = -1;
	for (int i = 0; i < length; ++i)
	{
		if (entered[i] == ')')
		{
			while (operations->top->next->value != '(')
			{
				rendered[++j] = pop(operations);
			}
			deleteElement(operations);
		}
		else
		{
			if ((entered[i] >= '0') && (entered[i] <= '9'))
			{
				rendered[++j] = entered[i];
			}
			else
			{
				if (entered[i] == '(')
				{
					add('(', operations);
				}
				else
				{
					if ((entered[i] == '+') || (entered[i] == '*') || (entered[i] == '/') || (entered[i] == '-'))
					{
						if (isEmpty(operations))
						{
							add(entered[i], operations);
						}
						else
						{
							if (priority(operations->top->next->value) < priority(entered[i]))
							{
								add(entered[i], operations);
							}
							else
							{
								while ((!isEmpty(operations)) && (priority(operations->top->value) >= priority(entered[i])))
								{
									rendered[++j] = pop(operations);
								}
								add(entered[i], operations);
							}
						}
					}
				}
			}
		}
	}
	while (!isEmpty(operations))
	{
		rendered[++j] = pop(operations);
	}
	for (int i = 0; i <= j; ++i)
	{
		std::cout << rendered[i] << " ";
	}
	removeAll(operations);
}