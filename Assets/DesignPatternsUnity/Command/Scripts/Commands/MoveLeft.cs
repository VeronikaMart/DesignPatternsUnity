using UnityEngine;

namespace DesignPatterns.Command
{
    // Concrete Command
    public class MoveLeft : Command
    {
        public override void Execute(Transform transform, Command command)
        {
            Move(transform);

            //Save the command
            InputHandler.oldCommands.Add(command);
        }

        public override void UndoCommand(Transform transform)
        {
            transform.Translate(transform.right * moveDistance);
        }

        public override void Move(Transform transform)
        {
            transform.Translate(-transform.right * moveDistance);
        }
    }
}