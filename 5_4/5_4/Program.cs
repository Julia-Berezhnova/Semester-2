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
            List<string> log = new List<string>();

            eventLoop.RegisterLeftHandler(game.OnLeft);
            eventLoop.RegisterRightHandler(game.OnRight);
            eventLoop.RegisterUpHandler(game.OnUp);
            eventLoop.RegisterDownHandler(game.OnDown);

            eventLoop.RegisterLeftHandler(() => log.Add("left"));
            eventLoop.RegisterRightHandler(() => log.Add("right"));
            eventLoop.RegisterUpHandler(() => log.Add("up"));
            eventLoop.RegisterDownHandler(() => log.Add("down"));
            eventLoop.Run();
        }
    }
}
