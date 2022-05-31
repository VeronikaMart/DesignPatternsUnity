using UnityEngine;

namespace DesignPatterns.Decorator
{
    public class DecoratorRunner : MonoBehaviour
    {
        private Weapon pistol = new Pistol("PB", 25);
        private WeaponDecorator weaponDecorator1 = new MagazineDecorator();
        private WeaponDecorator weaponDecorator2 = new MufflerDecorator();

        private bool spacePressed;

        private void Start()
        {
            weaponDecorator1.Weapon = pistol;
            weaponDecorator1.GetDescription();
        }

        private void Update()
        {
            // Add more functionality to the pistol
            if (Input.GetKeyDown(KeyCode.Space) && !spacePressed)
            {
                weaponDecorator2.GetDescription();
                spacePressed = true;
            }
        }
    }
}