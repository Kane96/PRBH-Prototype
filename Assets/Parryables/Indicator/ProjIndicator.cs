using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjIndicator : MonoBehaviour {

    public float xPosIncrement;

    private void Start() {
        gameObject.transform.position += Vector3.left * 530;
    }

    void Update () {
        gameObject.transform.position += Vector3.right * (xPosIncrement * Time.deltaTime);
	}
}
