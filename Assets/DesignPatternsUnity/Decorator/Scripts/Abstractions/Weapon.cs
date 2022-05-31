namespace DesignPatterns.Decorator
{
    // Provides an interface for objects that can be decorated
    public abstract class Weapon
    {
        protected string name;
        protected int id;

        public abstract void GetDescription();
    }
}