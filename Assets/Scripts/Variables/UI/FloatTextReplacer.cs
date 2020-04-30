using TMPro;
using UnityEngine;

public class FloatTextReplacer : MonoBehaviour {

    public bool alwaysUpdate;

    public TextMeshPro text;
    public FloatReference variable;

    private void OnEnable() {
        text.text = variable.Value.ToString();
    }

    private void Update() {
        if (alwaysUpdate) {
            text.text = variable.Value.ToString();
        }
    }

}