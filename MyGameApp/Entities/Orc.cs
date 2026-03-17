using System;

namespace MyGameApp.Entities
{
    public class Orc : Enemy
    {
        public Orc()
        {
            Name = "Orc";
            Health = 50;
            Damage = 15;
        }

        public override void Attack(Player target)
        {
            base.Attack(target);
            Console.WriteLine("Orc swings its axe!");
        }
    }
}