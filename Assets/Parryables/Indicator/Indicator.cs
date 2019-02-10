using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {

    public float timeToHit;
    public bool isMovingRight = true;
    private float xPosIncrement;
    
    private void Start() {
        float width = Screen.width / 2;
        xPosIncrement = width / timeToHit;

        if (!isMovingRight) {
            xPosIncrement = -xPosIncrement;
            width = -width;
        }

        gameObject.transform.position += Vector3.left * width;
    }

    void Update () {
        timeToHit -= Time.deltaTime;
        if (timeToHit <= 0) {
            Destroy(gameObject);
        }
        gameObject.transform.position += Vector3.right * (xPosIncrement * Time.deltaTime);
	}
}
