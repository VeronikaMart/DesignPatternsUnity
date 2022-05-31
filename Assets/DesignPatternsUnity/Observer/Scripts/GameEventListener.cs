using UnityEngine;
using UnityEngine.Events;

namespace DesignPatterns.Observer
{
    public class GameEventListener : MonoBehaviour
    {
        [SerializeField] private GameEvent gameEvent; // Event to trigger with
        [SerializeField] private UnityEvent onEventTriggered; // Response when event is triggered

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
}