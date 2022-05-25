using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private GameEvent gameEvent;

    private void Update()
    {
        // Trigger that invoke the event
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameEvent.TriggerEvent();
        }
    }
}