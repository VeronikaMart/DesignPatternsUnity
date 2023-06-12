using UnityEngine;

namespace Patterns2022.Strategy
{
    public class EnemySoldier : Enemy
    {
        public EnemySoldier()
        {
            kickBehavior = new SimpleKick();
            shootBehavior = new NoShoot();
        }

        public override void Display()
        {
            Debug.Log("This is the soldier");
        }
    }
}