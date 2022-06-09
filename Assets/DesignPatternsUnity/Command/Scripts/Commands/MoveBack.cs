using UnityEngine;

namespace DesignPatterns.Command
{
    // Concrete Command
    public class MoveBack : Command
    {
        public override void Execute(Transform transform, Command command)
        {
            Move(transform);

            //Save the command
            InputHandler.oldCommands.Add(command);
        }

        public override void UndoCommand(Transform transform)
        {
            transform.Translate(transform.forward * moveDistance);
        }

        public override void Move(Transform transform)
        {
            transform.Translate(-transform.forward * moveDistance);
        }
    }
}