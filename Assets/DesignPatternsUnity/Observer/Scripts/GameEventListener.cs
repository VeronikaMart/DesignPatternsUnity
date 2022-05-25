using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [Tooltip("Event to trigger with")]
    [SerializeField] private GameEvent gameEvent;
    [SerializeField] private UnityEvent onEventTriggered; // Response to invoke when event is triggered

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventTriggered()
    {
        onEventTriggered.Invoke();
    }
}