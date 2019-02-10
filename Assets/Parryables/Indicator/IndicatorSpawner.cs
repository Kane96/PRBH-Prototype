using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorSpawner : MonoBehaviour {

    public GameObject indicator;
    public float fireRate;
    private float nextFire;
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.P)) {
            GameObject newIndicator = Instantiate(indicator, transform.position, Quaternion.identity) as GameObject;
            newIndicator.transform.SetParent(gameObject.transform);
        }
    }
}
