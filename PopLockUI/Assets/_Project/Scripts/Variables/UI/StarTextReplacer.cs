using TMPro;
using UnityEngine;

public class StarTextReplacer : MonoBehaviour {

    public bool alwaysUpdate;

    public TextMeshProUGUI text;
    public FloatReference variable;

    private void OnEnable() {
        text.text = $"Stars: {variable.Value}";
    }

    private void Update() {
        if (alwaysUpdate) {
            text.text = $"Stars: {variable.Value}";
        }
    }

}