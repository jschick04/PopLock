using UnityEngine;

public class BoolReference : MonoBehaviour {

    public bool constantValue;
    public bool useConstant = true;
    public BoolVariable variable;

    public BoolReference() { }

    public BoolReference(bool value) {
        useConstant = true;
        constantValue = value;
    }

    public bool Value => useConstant ? constantValue : variable.Value;

    public static implicit operator bool(BoolReference reference) => reference.Value;

}