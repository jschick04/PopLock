using UnityEngine;
using UnityEngine.Events;

public enum Direction { Clockwise = -1, CounterClockwise = 1 }

public class DotMover : MonoBehaviour {

    public Transform lockBase;
    public MarkerMover marker;
    public SpriteRenderer sprite;

    private Direction _currentDirection = Direction.CounterClockwise;
    private bool _isScoreable;
    private Vector3 _startingPosition;

    public void ChangeDirection() {
        switch (_currentDirection) {
            case Direction.Clockwise :
                _currentDirection = Direction.CounterClockwise;
                break;
            case Direction.CounterClockwise :
                _currentDirection = Direction.Clockwise;
                break;
        }
    }

    public void NewLevel() {
        transform.localPosition = _startingPosition;
        _currentDirection = Direction.CounterClockwise;

        NewPosition();
    }

    public void NewPosition() {
        int angle = Random.Range(_minAngle, _maxAngle);

        transform.RotateAround(lockBase.position, Vector3.forward, angle * (int)_currentDirection);

        if (!sprite.enabled) {
            sprite.enabled = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision) {
        _isScoreable = true;
    }

    public void OnTriggerExit2D(Collider2D collision) {
        _isScoreable = false;
    }

    private void OnTap() {
        if (!isRunning.Value) {
            return;
        }

        if (_isScoreable) {
            onScored.Invoke();

            sprite.enabled = false;

            if (remainingDots.Value > 0) {
                ChangeDirection();
                NewPosition();
            }
        } else {
            onFailedAttempt.Invoke();
        }
    }

    private void Start() {
        _startingPosition = transform.localPosition;

        NewPosition();
    }

    // @formatter:off

    [Header("Rotations")]
    [SerializeField] private int _maxAngle = 10;
    [SerializeField] private int _minAngle = 180;

    public Direction CurrentDirection => _currentDirection;

    [Header("Game State")]
    public FloatVariable remainingDots;
    public BoolVariable isRunning;

    [Header("Events")]
    public UnityEvent onFailedAttempt;
    public UnityEvent onScored;

    // @formatter:on

}