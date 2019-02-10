using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {


    public float timeToHit;
    private float xPosIncrement;

    private void Start() {
        float width = Screen.width / 2;
        gameObject.transform.position += Vector3.left * width;
    }

    void Update () {
        gameObject.transform.position += Vector3.right * (xPosIncrement * Time.deltaTime);
	}
}
