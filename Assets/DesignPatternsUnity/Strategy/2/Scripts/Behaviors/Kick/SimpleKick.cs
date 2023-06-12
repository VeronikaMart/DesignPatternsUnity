using UnityEngine;

namespace Patterns2022.Strategy
{
    public class SimpleKick : IKickBehavior
    {
        public void Kick()
        {
            Debug.Log("Simple Kick!");
        }
    }
}