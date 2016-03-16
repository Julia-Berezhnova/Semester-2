using System;

namespace _4
{
    public class Game
    {
        public void OnLeft()
        {
            try
            {
                Console.CursorLeft -= 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.CursorLeft = Console.BufferWidth;   
            }
        }

        public void OnRight()
        {
            try
            {
                Console.CursorLeft += 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.CursorLeft = 0;
            }
        }

        public void OnUp()
        {
            try
            {
                Console.CursorTop -= 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.CursorTop = Console.BufferHeight - 1;
            }
        }

        public void OnDown()
        {
            try
            {
                Console.CursorTop += 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.CursorTop = 0;
            }
        }
    }
}

