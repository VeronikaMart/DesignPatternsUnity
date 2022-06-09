using UnityEngine;

namespace DesignPatterns.State
{
    // Concrete State
    public class ZeroDepth : State
    {
        public ZeroDepth()
        {
            Debug.Log("You're out of the water!");
        }

        protected override void ChangeState(Diver diver, Depth depth)
        {
            switch (depth)
            {
                case Depth.Increase:
                    diver.State = new NormalDepth();
                    break;
                case Depth.Decrease:
                    Debug.Log("Your depth is already zero.");
                    break;
                default:
                    break;
            }
        }
    }
}