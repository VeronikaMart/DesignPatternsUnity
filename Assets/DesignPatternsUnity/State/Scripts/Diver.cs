using UnityEngine;

namespace DesignPatterns.State
{
    // Context
    public class Diver : MonoBehaviour
    {
        public State State { private get; set; }

        private void Start()
        {
            State = new ZeroDepth();
        }

        private void Update()
        {
            Dive();
        }

        private void Dive()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                State.HandleDepth(this, Depth.Increase);
            }

            else if (Input.GetKeyDown(KeyCode.S))
            {
                State.HandleDepth(this, Depth.Decrease);
            }
        }
    }
}