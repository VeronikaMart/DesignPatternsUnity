using UnityEngine;

namespace DesignPatterns.Command
{
    // Provides an interface to perform an operation
    public abstract class Command
    {
        protected float moveDistance = 3f; // How far should the object move

        public abstract void Execute(Transform transform, Command command);

        public virtual void UndoCommand(Transform transform) { }

        public virtual void Move(Transform transform) { }
    }
}