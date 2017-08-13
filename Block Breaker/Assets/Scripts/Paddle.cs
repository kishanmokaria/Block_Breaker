using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


	void Start () {
		
	}
	
	void Update () {
        Vector3 paddlePos = new Vector3(this.transform.position.x,this.transform.position.y, 0f);
        float mousePosInBlocks =( Input.mousePosition.x / Screen.width )* 8;
       // print(mousePosInBlocks);
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, 1.25f, 8.25f);
        this.transform.position = paddlePos;
    }
}
