using MyGameApp.Entities;

namespace MyGameApp.Core
{
    public abstract class EnemyFactory
    {
        public abstract Enemy CreateEnemy();

        public void SpawnEnemy(Player target)
        {
            Enemy enemy = CreateEnemy();
            Console.WriteLine($"A wild {enemy.Name} appears!");
            enemy.Attack(target);
        }
    }
}