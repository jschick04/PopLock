using TMPro;
using UnityEngine;

public class LevelTextReplacer : MonoBehaviour {

    public bool alwaysUpdate;

    public TextMeshProUGUI text;
    public FloatReference variable;

    private void OnEnable() {
        text.text = $"Level: {variable.Value}";
    }

    private void Update() {
        if (alwaysUpdate) {
            text.text = $"Level: {variable.Value}";
        }
    }

}