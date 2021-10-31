namespace GameLib
{
    public class Villain
    {
        public string Name {get; set;}
        public int Health {get; set;}
        public string ID{get; set;}
        public Villain(string name, int health, string iD)
        {
            Name = name;
            Health = health;
            ID = iD;
        }
    }
}