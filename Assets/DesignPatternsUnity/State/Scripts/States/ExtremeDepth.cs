using UnityEngine;

namespace DesignPatterns.State
{
    // Concrete State
    public class ExtremeDepth : State
    {
        public ExtremeDepth()
        {
            Debug.Log("Extreme depth, danger!!!");
        }

        protected override void ChangeState(Diver diver, Depth depth)
        {
            switch (depth)
            {
                case Depth.Increase:
                    diver.State = new DeadlyDepth();
                    break;
                case Depth.Decrease:
                    diver.State = new AverageDepth();
                    break;
                default:
                    break;
            }
        }
    }
}