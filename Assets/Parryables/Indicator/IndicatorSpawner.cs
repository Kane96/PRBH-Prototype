using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorSpawner : MonoBehaviour {

    public GameObject indicator;
    private float screenWidth;
    public float timeToHit;
    public GameObject parryArea;

    private void Start() {
        screenWidth = Screen.width / 2;
    }

    public void SpawnIndicator(float timeToHit, bool movingRight) {
        float xPosIncrement = screenWidth / timeToHit;
        Vector3 spawnPoint;
        if (!movingRight) {
            spawnPoint = new Vector3(screenWidth, transform.position.y, 0);
            xPosIncrement = -xPosIncrement;
        } else {
            spawnPoint = new Vector3(-screenWidth, transform.position.y, 0);
        }

        GameObject newIndicator = Instantiate(indicator, spawnPoint, Quaternion.identity) as GameObject;
        newIndicator.transform.SetParent(parryArea.transform, false);
        newIndicator.GetComponent<Indicator>().Initialise(timeToHit, xPosIncrement, movingRight);
    }
}
