using UnityEngine;

namespace DesignPatterns.Decorator
{
    // Contains additional functionality, which will expand the target object
    public class MagazineDecorator : WeaponDecorator
    {
        public MagazineDecorator()
        {
            addedFunctionality = "Extra magazine";
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Debug.Log(addedFunctionality);
        }
    }
}