using UnityEngine;
using UnityEngine.Pool;

namespace DesignPatterns.ObjectPool
{
    public class BulletSpawner : MonoBehaviour
    {
        [SerializeField] private int maxPoolSize = 5; // If the quantity is greater, destroy the excess
        [SerializeField] private Bullet bulletPrefab;

        private IObjectPool<Bullet> bulletPool;

        private void Awake()
        {
            bulletPool = new ObjectPool<Bullet>(
                CreateBullet,
                OnTakeFromPool,
                OnReturnedToPool,
                OnDestroyPoolObject,
                maxSize: maxPoolSize);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                bulletPool.Get();
            }
        }

        private Bullet CreateBullet()
        {
            Bullet bullet = Instantiate(bulletPrefab);
            bullet.Pool = bulletPool;
            return bullet;
        }

        private void OnTakeFromPool(Bullet bullet)
        {
            bullet.gameObject.SetActive(true);
            bullet.transform.position = transform.position;
        }

        private void OnReturnedToPool(Bullet bullet)
        {
            bullet.gameObject.SetActive(false);
        }

        private void OnDestroyPoolObject(Bullet bullet)
        {
            Destroy(bullet.gameObject);
        }
    }
}