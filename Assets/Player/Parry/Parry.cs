using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parry : MonoBehaviour {

	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Parriable") {
            print("Poop");
            if (Input.GetKeyDown(KeyCode.Space)) {
                print(other.name);
            }
        }
    }
}
