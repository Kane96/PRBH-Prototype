using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour {

    public GameObject projectile;
    public float fireRate;
    private float nextFire;

    void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }

        if (Time.time > nextFire) {
            Instantiate(projectile, transform.position, Quaternion.identity);
            nextFire += fireRate;
        }   
	}
}