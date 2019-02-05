using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour {

    public GameObject cube;
    public Transform player;
    private Vector3 startingPos;

    void Start() {
        startingPos = gameObject.transform.position;    
    }

    void Update () {
        transform.LookAt(cube.transform);
        transform.position = player.position + startingPos;
    }
}
