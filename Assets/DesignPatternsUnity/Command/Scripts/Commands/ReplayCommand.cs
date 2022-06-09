using UnityEngine;

namespace DesignPatterns.Command
{
    public class ReplayCommand : Command
    {
        public override void Execute(Transform transform, Command command)
        {
            InputHandler.shouldStartReplay = true;
        }
    }
}