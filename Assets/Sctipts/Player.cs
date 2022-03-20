using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ePlayer { 
    Left,
    Right 
}



public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    public ePlayer player;

    // Update is called once per frame
    void Update()
    {
        float inputSpeed = 0f;
        if (player == ePlayer.Left)
        {
            inputSpeed = Input.GetAxisRaw("PlayerLeft");
        }
        else if (player == ePlayer.Right) {
            inputSpeed = Input.GetAxisRaw("PlayerRight");
        }

        transform.position += new Vector3(0, 0, inputSpeed * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out MoveBall ball)) {
            ball.UpSpeedLevel();
        }
    }
}
