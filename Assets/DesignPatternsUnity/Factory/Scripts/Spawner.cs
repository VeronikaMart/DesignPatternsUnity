using UnityEngine;

namespace DesignPatterns.Factory
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private CubeFactory cubeFactory;
        private float timer = 3f;

        private void Update()
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                var cubeObject = cubeFactory.InstantiateObject();

                cubeObject.transform.position = new Vector2(Random.Range(-6f, 6f), Random.Range(-6f, 6f));
                timer = 3;
            }
        }
    }
}