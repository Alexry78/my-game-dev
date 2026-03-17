using MyGameApp.Entities;

namespace MyGameApp.Core
{
    public class GoblinFactory : EnemyFactory
    {
        public override Enemy CreateEnemy()
        {
            return new Goblin();
        }
    }
}