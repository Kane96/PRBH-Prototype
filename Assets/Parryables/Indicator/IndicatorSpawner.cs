using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorSpawner : MonoBehaviour {

    public GameObject indicator;
    private Vector3 spawnPoint;
    private float screenWidth;
    public float timeToHit;

    private void Start() {
        screenWidth = Screen.width / 2;
        spawnPoint = new Vector3(screenWidth, transform.position.y, 0);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.P)) {
            spawnIndicator(timeToHit, true, spawnPoint);
        }
    }

    public void spawnIndicator(float timeToHit, bool movingRight, Vector3 spawnPoint) {
        float xPosIncrement = screenWidth / timeToHit;
        if (!movingRight) {
            xPosIncrement = -xPosIncrement;
            spawnPoint = -spawnPoint;
        }

        GameObject newIndicator = Instantiate(indicator, spawnPoint, Quaternion.identity) as GameObject;
        newIndicator.transform.SetParent(gameObject.transform);
        newIndicator.GetComponent<Indicator>().Initialise(timeToHit, xPosIncrement, movingRight);
    }
}
