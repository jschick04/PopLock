using UnityEngine;

public class AnimatorParameterSetter : MonoBehaviour {

    public Animator animator;
    public string parameterName;
    public FloatVariable variable;

    private int _parameterHash;

    private void OnValidate() => _parameterHash = Animator.StringToHash(parameterName);

    private void Update() {
        animator.SetFloat(_parameterHash, variable.Value);
    }

}