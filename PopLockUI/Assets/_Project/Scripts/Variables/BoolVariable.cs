using UnityEngine;

[CreateAssetMenu]
public class BoolVariable : ScriptableObject {

    [SerializeField] private bool _value;

    public bool Value => _value;

    public void SetValue(bool newValue) {
        _value = newValue;
    }

    public void SetValue(BoolVariable newValue) {
        _value = newValue.Value;
    }

}