using UnityEngine;

namespace DesignPatterns.Strategy
{
    // Abstract Strategy
    public interface IBoost
    {
        public void Use(GameObject currentGameObject);
    }
}