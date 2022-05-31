using UnityEngine;

namespace DesignPatterns.Decorator
{
    // Class of the target object to be decorated
    public class Pistol : Weapon
    {
        public Pistol(string name, int id)
        {
            base.name = name;
            base.id = id;
        }

        public override void GetDescription()
        {
            Debug.Log($"It's a {name} pistol, id {id}. Available upgrades:");
        }
    }
}