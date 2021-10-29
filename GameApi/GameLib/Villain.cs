namespace GameLib
{
    public class Villain
    {
        public string Name {get; set;}
        public int Health {get; set;}
        public int ID{get; set;}
        public Villain(string name, int health, int iD)
        {
            Name = name;
            Health = health;
            ID = iD;
        }
    }
}