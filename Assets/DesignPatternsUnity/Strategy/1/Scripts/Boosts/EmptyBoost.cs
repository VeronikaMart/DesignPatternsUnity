using UnityEngine;

namespace DesignPatterns.Strategy
{
    // Concrete Strategy
    public class EmptyBoost : IBoost
    {
        public void Use(GameObject currentGameObject)
        {
            Debug.Log("No boost");
        }
    }
}