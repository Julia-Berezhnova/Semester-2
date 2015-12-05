#pragma once

struct Stack;
struct StackElement;
Stack *createStack();
StackElement *newElement(char symbol, StackElement *next);
void add(char symbol, Stack *stack);
Stack *createStack();
bool isEmpty(Stack *stack);
char pop(Stack *stack);
void deleteElement(Stack *stack);
void removeAll(Stack *stack);
int priority(char c);
void count(char entered[], int length);