using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParryableController : MonoBehaviour {

    public ProjectileSpawner projectileSpawner;
    public IndicatorSpawner indicatorSpawner;

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
        indicatorSpawner.SpawnIndicator(timeToHit, true);
    }
}
