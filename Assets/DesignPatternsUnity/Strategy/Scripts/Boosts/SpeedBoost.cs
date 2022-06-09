using UnityEngine;

namespace DesignPatterns.Strategy
{
    // Concrete Strategy
    public class SpeedBoost : IBoost
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("You sped up");
        }
    }
}