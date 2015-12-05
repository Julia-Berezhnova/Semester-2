#pragma once

const int maxSize = 1000;

struct Stack;

Stack* createStack();

void push(char newElement, Stack *stack);

char pop(Stack *stack);

bool isEmpty(Stack *stack);

void deleteStack(Stack* stack);