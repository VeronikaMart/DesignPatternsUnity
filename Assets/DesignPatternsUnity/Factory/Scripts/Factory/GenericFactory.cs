using UnityEngine;

namespace DesignPatterns.Factory
{
    public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private T obj;

        public T InstantiateObject()
        {
            return Instantiate(obj, transform);
        }
    }
}