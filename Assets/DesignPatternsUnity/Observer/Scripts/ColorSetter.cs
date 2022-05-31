using UnityEngine;

namespace DesignPatterns.Observer
{
    public class ColorSetter : MonoBehaviour
    {
        [SerializeField] private Material[] materials;
        private MeshRenderer mesh;

        private void Awake()
        {
            mesh = GetComponent<MeshRenderer>();
        }

        // Action which happens when the event is invoked
        public void SetRandomColor()
        {
            int random = Random.Range(0, materials.Length);
            mesh.material = materials[random];
        }
    }
}