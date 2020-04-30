using UnityEngine;
using UnityEngine.Events;

public class StateButtons : MonoBehaviour {

    public void BeginGame() {
        beginButton.SetActive(false);

        onStartGame.Invoke();
    }

    public void FailedGame() {
        restartButton.SetActive(true);
    }

    public void NewLevel() {
        beginButton.SetActive(true);
        restartButton.SetActive(false);
    }

    public void RestartGame() {
        NewLevel();

        onRestartGame.Invoke();
    }

    private void Start() {
        NewLevel();
    }

    #region Variables

    public GameObject beginButton;
    public GameObject restartButton;

    public UnityEvent onStartGame;
    public UnityEvent onRestartGame;

    #endregion

}