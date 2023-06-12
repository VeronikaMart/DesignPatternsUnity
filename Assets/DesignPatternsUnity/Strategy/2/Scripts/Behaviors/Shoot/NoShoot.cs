using UnityEngine;

namespace Patterns2022.Strategy
{
    public class NoShoot : IShootBehavior
    {
        public void Shoot()
        {
            Debug.Log("No Shoot!");
        }
    }
}