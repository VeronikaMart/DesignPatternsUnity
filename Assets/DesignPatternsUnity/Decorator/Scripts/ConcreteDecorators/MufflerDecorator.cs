using UnityEngine;

namespace DesignPatterns.Decorator
{
    // Contains additional functionality, which will expand the target object
    public class MufflerDecorator : WeaponDecorator
    {
        public MufflerDecorator()
        {
            addedFunctionality = "Muffler";
        }

        public override void GetDescription()
        {
            base.GetDescription();
            Debug.Log(addedFunctionality);
        }
    }
}