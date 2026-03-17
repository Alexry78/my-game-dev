using System;

namespace MyGameApp.Entities
{
    public class Goblin : Enemy
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 20;
            Damage = 5;
        }

        public override void Attack(Player target)
        {
            base.Attack(target);
            Console.WriteLine("Goblin stabs with a dagger!");
        }
    }
}