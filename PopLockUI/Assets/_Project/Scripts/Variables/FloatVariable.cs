using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject {

    [SerializeField] private float _value;

    public float Value => _value;

    public void ApplyChange(float amount) {
        _value += amount;
    }

    public void ApplyChange(FloatVariable amount) {
        _value += amount.Value;
    }

    public void SetValue(float newValue) {
        _value = newValue;
    }

    public void SetValue(FloatVariable newValue) {
        _value = newValue.Value;
    }

}