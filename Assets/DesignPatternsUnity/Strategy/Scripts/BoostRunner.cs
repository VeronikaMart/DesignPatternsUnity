using UnityEngine;

namespace DesignPatterns.Strategy
{
    // Context
    public class BoostRunner : MonoBehaviour
    {
        private IBoost currentBoost = new EmptyBoost();

        private void Start()
        {
            UseBoost(currentBoost);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UseBoost(new HealBoost());
            }
        }

        private void UseBoost(IBoost boost)
        {
            currentBoost = boost;
            currentBoost.Use(gameObject);
        }
    }
}