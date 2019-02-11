﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {

    public float timeToHit;
    public float stayAfterHit;
    public bool isMovingRight = true;
    private float xPosIncrement;

    void Update () {
        timeToHit -= Time.deltaTime;

        if (timeToHit <= 0) {
            stayAfterHit -= Time.deltaTime;
            xPosIncrement = 0;
            if (stayAfterHit <= 0) {
                Destroy(gameObject);
            }
        }

        gameObject.transform.position += Vector3.right * (xPosIncrement * Time.deltaTime);
	}

    public void Initialise(float timeToHit, float xPosIncrement, bool movingRight) {

    }
}
