using UnityEngine;

namespace DesignPatterns.Factory
{
    public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private T spawnedObject;

        public T InstantiateObject()
        {
            return Instantiate(spawnedObject, transform);
        }
    }
}