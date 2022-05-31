namespace DesignPatterns.Decorator
{
    // Provides a common interface for decorator objects
    public abstract class WeaponDecorator : Weapon
    {
        public Weapon Weapon { protected get; set; }
        protected string addedFunctionality;

        public override void GetDescription()
        {
            if (!ReferenceEquals(Weapon, null))
            {
                Weapon.GetDescription();
            }
        }
    }
}