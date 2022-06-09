using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command
{
    public class UndoCommand : Command
    {
        public override void Execute(Transform transform, Command command)
        {
            List<Command> oldCommands = InputHandler.oldCommands;

            if (oldCommands.Count > 0)
            {
                Command lastCommand = oldCommands[oldCommands.Count - 1];

                //Move the object with this command
                lastCommand.UndoCommand(transform);

                //Remove the command from the list
                oldCommands.RemoveAt(oldCommands.Count - 1);
            }
        }
    }
}