using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour {

    public void SpawnProjectile(GameObject projectile, float timeToHit, Transform projSpawnPos) {
        GameObject proj = Instantiate(projectile, projSpawnPos.position, Quaternion.identity) as GameObject;
        proj.GetComponent<Projectile>().SetTimeToHit(timeToHit);
    }
}