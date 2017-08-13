using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public bool hasStarted = false;
    private Paddle paddle;
    private Brick brick;
    private Vector3 paddleToBallVector;

	void Start () {
        brick = GameObject.FindObjectOfType<Brick>();
        paddle = GameObject.FindObjectOfType<Paddle>(); 
        paddleToBallVector = this.transform.position - paddle.transform.position;
      
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    void Update () {
        if (!hasStarted) {
            this.transform.position = paddle.transform.position + paddleToBallVector;
            if (Input.GetMouseButtonDown(0))
            {
                print("Left Click, Launching");
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 5f);
            }
        }
    }
}
