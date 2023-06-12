using UnityEngine;

namespace Patterns2022.Strategy
{
    public class EnemyBoss : Enemy
    {
        public EnemyBoss()
        {
            kickBehavior = new SuperKick();
            shootBehavior = new BlasterShoot();
        }

        public override void Display()
        {
            Debug.Log("This is the boss!");
        }
    }
}