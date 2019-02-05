using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject projectile;

    void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
	}
}