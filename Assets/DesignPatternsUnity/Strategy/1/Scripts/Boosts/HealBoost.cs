using UnityEngine;

namespace DesignPatterns.Strategy
{
    // Concrete Strategy
    public class HealBoost : IBoost
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("You are healed");
        }
    }
}