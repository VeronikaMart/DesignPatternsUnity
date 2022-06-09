using UnityEngine;

namespace DesignPatterns.State
{
    // Concrete State
    public class NormalDepth : State
    {
        public NormalDepth()
        {
            Debug.Log("Normal depth, enjoy diving!");
        }

        protected override void ChangeState(Diver diver, Depth depth)
        {
            switch (depth)
            {
                case Depth.Increase:
                    diver.State = new AverageDepth();
                    break;
                case Depth.Decrease:
                    diver.State = new ZeroDepth();
                    break;
                default:
                    break;
            }
        }
    }
}