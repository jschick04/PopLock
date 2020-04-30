using UnityEngine;
using UnityEngine.Events;

public class DotManager : MonoBehaviour {

    public void RemoveDot() {
        dots.ApplyChange(-1);

        if (dots.Value <= 0) {
            onLevelComplete.Invoke();
        }
    }

    public void Restart() {
        if (resetDots) {
            dots.SetValue(startingDots);
        }
    }

    public void SetCurrent() {
        dots.SetValue(currentLevel);
    }

    public void Start() {
        Restart();
    }

    #region Variables

    public bool resetDots;

    public FloatVariable dots;
    public FloatReference startingDots;

    public FloatVariable currentLevel;

    public UnityEvent onLevelComplete;

    #endregion

}