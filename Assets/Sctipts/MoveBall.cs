
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class MoveBall : MonoBehaviour
{
    [SerializeField] private Vector3 initialImpulse;
    [SerializeField] private float forceMode;
    [SerializeField] private float speedAddForce;
    [SerializeField] private float MaxForceMode;
    [SerializeField] private Text PlayerScore;

    private Rigidbody _rigidbody;
    private Vector3 initialPoint;
    private int Level = 0;
    void Start()
    {
        initialPoint = transform.position;
        _rigidbody = GetComponent<Rigidbody>();
        SetDataInfoGame();
        MovedBall();
    }

    public void MovedBall() {
        transform.position = initialPoint;
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.AddForce(initialImpulse * forceMode, ForceMode.Impulse);
    }
    public void UpSpeedLevel() {
        if (forceMode < MaxForceMode) {
            forceMode += speedAddForce;
            Level++;
            SetDataInfoGame();
        }
    }

    private void SetDataInfoGame() {
        PlayerScore.text = Level.ToString() + " / " + forceMode.ToString();
    }
}
