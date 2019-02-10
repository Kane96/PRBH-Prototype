using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorSpawner : MonoBehaviour {

    public GameObject indicator;
    public float fireRate;
    private float nextFire;

    void Start () {
        print(Screen.width);
	}
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.P)) {
            indicator = Instantiate(indicator, transform.position, Quaternion.identity) as GameObject;
            indicator.transform.parent = gameObject.transform;
        }
    }
}
