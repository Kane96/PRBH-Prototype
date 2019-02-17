using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryableController : MonoBehaviour {

    public ProjectileSpawner projectileSpawner;
    public GameObject indicatorSpawner;

    public float timeToHit;

    public GameObject projectile;
    public Transform projSpawnPos;

	void Update () {
        if (Input.GetKeyDown(KeyCode.P)) {
            ShootProjectile();
        }
    }

    private void ShootProjectile() {
        projectileSpawner.SpawnProjectile(projectile, timeToHit, projSpawnPos);
        //indicator.fire(timeToHit)
    }
}
