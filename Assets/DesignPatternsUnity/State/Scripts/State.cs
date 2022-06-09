namespace DesignPatterns.State
{
    // Abstract State
    public abstract class State
    {
        public virtual void HandleDepth(Diver diver, Depth depth)
        {
            ChangeState(diver, depth);
        }

        protected abstract void ChangeState(Diver diver, Depth depth);
    }
}