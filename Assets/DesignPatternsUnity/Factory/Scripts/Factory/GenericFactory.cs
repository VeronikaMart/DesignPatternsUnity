using UnityEngine;

namespace DesignPatterns.Factory
{
    // Provides generic factory for generating objects
    public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private T spawnedObject;

        public T InstantiateObject()
        {
            return Instantiate(spawnedObject, transform);
        }
    }
}