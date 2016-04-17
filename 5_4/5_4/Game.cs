using System;

namespace _4
{
    public class Game
    {
        public void OnLeft(object sender, EventArgs args)
        {
            if (Console.CursorLeft - 1 < 0)
                Console.CursorLeft = Console.BufferWidth - 1;       
            else
                Console.CursorLeft -= 1;
        }

        public void OnRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft + 1 >= Console.BufferWidth)
                Console.CursorLeft = 0;
            else
                Console.CursorLeft += 1;            
        }

        public void OnUp(object sender, EventArgs args)
        {
            if (Console.CursorTop - 1 < 0)
                Console.CursorTop = Console.BufferHeight - 1;
            else
                Console.CursorTop -= 1;
        }

        public void OnDown(object sender, EventArgs args)
        {
            if (Console.CursorTop + 1 >= Console.BufferHeight)
                Console.CursorTop = 0;
            else
                Console.CursorTop += 1;
        }
    }
}

