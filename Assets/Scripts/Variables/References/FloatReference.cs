using System;

[Serializable]
public class FloatReference {

    public float constantValue;
    public bool useConstant = true;
    public FloatVariable variable;

    public FloatReference() { }

    public FloatReference(float value) {
        useConstant = true;
        constantValue = value;
    }

    public float Value => useConstant ? constantValue : variable.Value;

    public static implicit operator float(FloatReference reference) => reference.Value;

}