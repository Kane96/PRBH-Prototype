using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    private CharacterController cc;

	void Start () {
        cc = GetComponent<CharacterController>();
    }

	void Update () {
        float moveX;
        float moveZ;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) {
            moveX = Round(Input.GetAxis("Horizontal"));
        } else {
            moveX = Input.GetAxis("Horizontal");
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) {
            moveZ = Round(Input.GetAxis("Vertical"));
        }
        else {
            moveZ = Input.GetAxis("Vertical");
        }

        moveX *= movementSpeed;
        moveZ *= movementSpeed;

        Vector3 newMove = new Vector3(moveX, 0, moveZ);
        cc.SimpleMove(newMove);

        if (newMove != Vector3.zero) // Don't return to default rotation
        {
            transform.rotation = Quaternion.LookRotation(newMove);
        }
    }

    private float Round(float input) {
        if (input > 0) {
            return Mathf.Ceil(input);
        } else {
            return Mathf.Floor(input);
        }
    }
}
