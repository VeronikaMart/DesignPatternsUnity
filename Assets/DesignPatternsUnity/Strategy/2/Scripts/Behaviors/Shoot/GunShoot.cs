using UnityEngine;

namespace Patterns2022.Strategy
{
    public class GunShoot : IShootBehavior
    {
        public void Shoot()
        {
            Debug.Log("Gun Shoot!");
        }
    }
}