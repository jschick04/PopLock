using UnityEngine;

public class GameManager : MonoBehaviour {

    public BoolVariable isRunning;

    public void LevelCompleted() {
        StopRunning();

        currentLevel.ApplyChange(1);
        currentSpeed.ApplyChange(speedIncrease);
    }

    public void Start() {
        StartLevel();
    }

    public void StartLevel() {
        if (resetLevels) {
            currentLevel.SetValue(startingLevel);
        }

        if (resetStars) {
            currentStars.SetValue(startingStars);
        }

        currentSpeed.SetValue(startingSpeed);

        isRunning.SetValue(false);
    }

    public void StartRunning() => isRunning.SetValue(true);

    public void StopRunning() => isRunning.SetValue(false);

    // @formatter:off

    [Header("Level")]
    public FloatVariable currentLevel;
    public bool resetLevels;
    public FloatReference startingLevel;

    [Header("Stars")]
    public FloatVariable currentStars;
    public bool resetStars;
    public FloatReference startingStars;

    [Header("Rotation Speed")]
    public float speedIncrease;
    public FloatVariable currentSpeed;
    public FloatReference startingSpeed;
    
    // @formatter:on

}