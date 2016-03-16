using System;

namespace ArrayStack
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayStack myStack = new ArrayStack();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            if (myStack.IsEmpty())
            {
                Console.WriteLine("The stack is empty");
            }
            while (!myStack.IsEmpty())
            {
                Console.WriteLine("Value in the stack: {0}", myStack.Pop());
            }
        }
    }
}
