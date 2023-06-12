using UnityEngine;

namespace Patterns2022.Strategy
{
    public class SuperKick : IKickBehavior
    {
        public void Kick()
        {
            Debug.Log("Super Kick!");
        }
    }
}