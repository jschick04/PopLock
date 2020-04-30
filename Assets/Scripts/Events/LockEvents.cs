using UnityEngine;
using UnityEngine.Events;

public class LockEvents : MonoBehaviour {

    public UnityEvent onLevelCompleted;

    public void LevelCompleted() {
        onLevelCompleted.Invoke();
    }

}