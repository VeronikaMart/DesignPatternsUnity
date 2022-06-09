using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPool
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Vector3 speed;
        private IObjectPool<Bullet> bulletPool;

        public IObjectPool<Bullet> Pool 
        { 
            private get => bulletPool; 
            set => bulletPool = value; 
        }

        private void Update()
        {
            transform.position += speed * Time.deltaTime;
        }

        private void OnBecameInvisible()
        {
            bulletPool.Release(this);
        }
    }
}