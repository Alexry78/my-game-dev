using System;

namespace MyGameApp.Entities
{
    public abstract class Enemy : Entity
    {
        public int Damage { get; set; }

        public virtual void Attack(Player target)
        {
            target.TakeDamage(Damage);
            Console.WriteLine($"{Name} attacks for {Damage} damage!");
        }
    }
}