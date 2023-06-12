using UnityEngine;

namespace Patterns2022.Strategy
{
    public class EnemyShooter : Enemy
    {
        // EnemyShooter uses the class GunShoot to perform an action,
        // so when calling PerformShoot()
        // responsibility for execution assigned to the GunShoot object.
        // And as an implementation of KickBehavior using type NoKick
        public EnemyShooter()
        {
            kickBehavior = new NoKick();
            shootBehavior = new GunShoot();
        }

        public override void Display()
        {
            Debug.Log("This is the shooter");
        }
    }
}