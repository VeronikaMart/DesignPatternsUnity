using UnityEngine;

namespace Patterns2022.Strategy
{
    public class BlasterShoot : IShootBehavior
    {
        public void Shoot()
        {
            Debug.Log("Blaster Shoot!");
        }
    }
}