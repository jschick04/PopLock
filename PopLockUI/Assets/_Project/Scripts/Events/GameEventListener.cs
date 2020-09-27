using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour {

    public GameEvent gameEvent;
    public UnityEvent response;

    public void OnEventRaised() {
        response.Invoke();
    }

    private void OnDisable() {
        gameEvent.UnregisterListener(this);
    }

    private void OnEnable() {
        gameEvent.RegisterListener(this);
    }

}