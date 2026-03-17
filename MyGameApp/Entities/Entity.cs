namespace MyGameApp.Entities
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }
    }
}
