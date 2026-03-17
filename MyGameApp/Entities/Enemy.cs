namespace MyGameApp.Entities
{
    public class Enemy : Entity
    {
        public int Damage { get; set; }

        public void Attack(Player target)
        {
            target.TakeDamage(Damage);
        }
    }
}
