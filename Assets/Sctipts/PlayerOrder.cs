using UnityEngine;
using UnityEngine.UI;

public class PlayerOrder : MonoBehaviour
{
    [SerializeField] private Text PlayerScore;


    private int score = 0;

    private void Start()
    {
        PlayerScore.text = score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        MoveBall ball = collision.gameObject.GetComponent<MoveBall>();
        if (ball != null) { 
            ball.MovedBall();
            score++;
            PlayerScore.text = score.ToString();
        }
    }
}
