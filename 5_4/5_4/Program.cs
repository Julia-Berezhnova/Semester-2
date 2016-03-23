using System;
using System.Collections.Generic;

namespace _4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EventLoop eventLoop = new EventLoop();
            Game game = new Game();

            eventLoop.LeftHandler += game.OnLeft;
            eventLoop.RightHandler += game.OnRight;
            eventLoop.UpHandler += game.OnUp;
            eventLoop.DownHandler += game.OnDown;

            var log = new List<string>();
            eventLoop.LeftHandler += (sender, eventArgs) => log.Add("left");
            eventLoop.RightHandler += (sender, eventArgs) => log.Add("right");
            eventLoop.UpHandler += (sender, eventArgs) => log.Add("up");
            eventLoop.DownHandler += (sender, eventArgs) => log.Add("down");

            eventLoop.Run();
        }
    }
}
