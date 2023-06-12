namespace Patterns2022.Strategy
{
    public abstract class Enemy
    {
        protected IKickBehavior kickBehavior;
        protected IShootBehavior shootBehavior;

        public abstract void Display();

        // Enemy object delegates behavior of the object
        // on which refers to kickBehavior
        public void PerformKick()
        {
            kickBehavior.Kick();
        }

        public void PerformShoot()
        {
            shootBehavior.Shoot();
        }

        // Allows you to dynamically change the behavior
        public void SetKickBehavior(IKickBehavior kickBehavior)
        {
            this.kickBehavior = kickBehavior;
        }

        public void SetShootBehavior(IShootBehavior shootBehavior)
        {
            this.shootBehavior = shootBehavior;
        }
    }
}