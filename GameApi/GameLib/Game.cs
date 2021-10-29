using System;
using System.Collections.Generic;

namespace GameLib
{
    public class Game
    {


        public DateTime GameTime {get;set;}
        public string Win{get;set;}

                public Game(DateTime gameTime, string win)
        {
            GameTime = gameTime;
            Win = win;
        }
    }
}