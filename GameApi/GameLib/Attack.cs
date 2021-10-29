namespace GameLib
{
    public class Attack
    {
        public Hero Attacker{get;set;}
        public Villain Target{get;set;}
        public int Damage{get;set;}

        public Attack(Hero attacker, Villain target, int damage)
        {
            Attacker = attacker;
            Target = target;
            Damage = damage;
        }
    }
}