using UnityEngine;

namespace DesignPatterns.State
{
    // Concrete State
    public class AverageDepth : State
    {
        public AverageDepth()
        {
            Debug.Log("Average depth, careful");
        }

        protected override void ChangeState(Diver diver, Depth depth)
        {
            switch (depth)
            {
                case Depth.Increase:
                    diver.State = new ExtremeDepth();
                    break;
                case Depth.Decrease:
                    diver.State = new NormalDepth();
                    break;
                default:
                    break;
            }
        }
    }
}