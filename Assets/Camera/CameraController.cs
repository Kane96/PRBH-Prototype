using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform player;
    private Vector3 startingPos;

    void Start() {
        startingPos = gameObject.transform.position;
    }

    void Update () {
        transform.position = player.position + startingPos;
	}
}
