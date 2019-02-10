﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    [Tooltip("In seconds.")]
    public float timeToHit;

    private CharacterController player;

    private float step = 0.1f;
    private float startingTime;
    private Vector3 closestPoint;

    void Start() {
        player = GameObject.Find("Player").GetComponent<CharacterController>();
    }

    void Update () {
        closestPoint = player.ClosestPoint(transform.position);
        timeToHit -= Time.deltaTime;
        step =  Vector3.Distance(transform.position, closestPoint) / (timeToHit * 60);

        if (step <= 0) {
            step = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, closestPoint, step);

        if (timeToHit <= 0) {
            Destroy(gameObject);
        }
	}

    /*
    private void OnTriggerEnter(Collider other) {
        print(timeToHitPlayer);
        Destroy(gameObject);
    }
    */
}
