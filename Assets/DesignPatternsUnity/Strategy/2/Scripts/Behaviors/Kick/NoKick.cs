using UnityEngine;

namespace Patterns2022.Strategy
{
    public class NoKick : IKickBehavior
    {
        public void Kick()
        {
            Debug.Log("No Kick!");
        }
    }
}