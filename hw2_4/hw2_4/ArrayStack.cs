﻿namespace Stacks
{
    /// <summary>
    /// Class stack based on array
    /// </summary>
    class ArrayStack: IStack
    {
        private const int maxElementsNumber = 100;

        private int currentSize;

        private int[] array = new int[maxElementsNumber];

        // class constructor
        public ArrayStack()
        {
            for (int i = 0; i < maxElementsNumber; ++i)
            {
                // just in case
                this.array[i] = 0; 
            }
            currentSize = 0;
        }

        public bool IsEmpty() => this.currentSize == 0;

        public void Push(int element)
        {
            if (currentSize < maxElementsNumber)
            {
                this.array[currentSize] = element;
                ++currentSize;               
            }
            else
            {
                throw new StackOverloadedException();
            }
        }

        public int Pop()
        {
            if (currentSize > 0)
            {
                --currentSize;
                return this.array[currentSize]; 
            }
            else
            {
                throw new StackEmptyException();
            }
        }

        public int Top()
        {
            if (!this.IsEmpty())
            {
                return this.array[currentSize - 1];
            }
            else
            { 
                throw new StackEmptyException();
            }
        }
    }
}

