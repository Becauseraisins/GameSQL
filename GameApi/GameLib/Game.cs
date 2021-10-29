using System;
using System.Collections.Generic;

namespace GameLib
{
    public class Game
    {
        System.DateTime GameTime;
        List<Hero> Heroes;
        List<Villain> Villains;
        string Win;

        public Game(DateTime gameTime, List<Hero> heroes, List<Villain> villains, string win)
        {
            GameTime = gameTime;
            Heroes = heroes;
            Villains = villains;
            Win = win;
        }
    }
}