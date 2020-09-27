using UnityEngine;

public class MarkerMover : MonoBehaviour {

    public DotMover dotMover;

    public BoolVariable isRunning;

    public Transform lockBase;
    public FloatVariable speed;

    private Vector3 _startingPosition;

    public void ResetPosition() {
        transform.localPosition = _startingPosition;
        transform.localRotation = Quaternion.identity;
    }

    private void Awake() {
        _startingPosition = transform.localPosition;
    }

    private void Update() {
        if (!isRunning.Value) {
            return;
        }

        transform.RotateAround(
            lockBase.position,
            Vector3.forward,
            speed.Value * Time.deltaTime * (int)dotMover.CurrentDirection
        );
    }

}