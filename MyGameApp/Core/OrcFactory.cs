using MyGameApp.Entities;

namespace MyGameApp.Core
{
    public class OrcFactory : EnemyFactory
    {
        public override Enemy CreateEnemy()
        {
            return new Orc();
        }
    }
}