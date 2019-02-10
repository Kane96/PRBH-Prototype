using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {

    public GameObject projIndicator;
    public float fireRate;
    private float nextFire;

    void Start () {
		
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.P)) {
            projIndicator = Instantiate(projIndicator, transform.position, Quaternion.identity) as GameObject;
            projIndicator.transform.parent = gameObject.transform;
        }
    }
}
