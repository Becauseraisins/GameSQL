using System;

namespace GameLib
{
    public class Hero
    {
        public string Name {get; set;}
        public int DiceMin{get; set;}
        public int DiceMax{get; set;}
        public int UsesLeft{get; set;}
        public string ID{get; set;}

        public Hero(string name, int diceMin, int diceMax, int usesLeft, string iD)
        {
            Name = name;
            DiceMin = diceMin;
            DiceMax = diceMax;
            UsesLeft = usesLeft;
            ID = iD;
        }
    }
    
}
