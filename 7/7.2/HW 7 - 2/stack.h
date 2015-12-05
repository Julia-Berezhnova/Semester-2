#pragma once

const int maxSize = 1000;

struct Stack;
Stack *createStack();
void push(double newElement, Stack *stack);
double pop(Stack *stack);
void add(Stack *stack);
void subtract(Stack *stack);
void multiply(Stack *stack);
void divide(Stack *stack);
