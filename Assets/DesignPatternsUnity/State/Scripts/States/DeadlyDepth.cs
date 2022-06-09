using UnityEngine;

namespace DesignPatterns.State
{
    // Concrete State
    public class DeadlyDepth : State
    {
        public DeadlyDepth()
        {
            Debug.Log("Deadly depth, you are dead!");
        }

        protected override void ChangeState(Diver diver, Depth depth) { }
    }
}