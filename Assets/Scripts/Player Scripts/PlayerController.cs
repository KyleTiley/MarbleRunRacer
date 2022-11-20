using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    new Rigidbody rigidbody;

    float playerForwardSpeed = 15;
    float playerReverseSpeed = 5;


    private void Awake() {
        rigidbody = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        if(Input.GetKey("w")){
            rigidbody.AddForce(Camera.main.transform.forward * playerForwardSpeed);
        }

        if(Input.GetKey("s")){
            rigidbody.AddForce(Camera.main.transform.forward * -1 * playerReverseSpeed);
        }

        if(Input.GetKey("a")){
            rigidbody.AddForce(Camera.main.transform.right * -1 * playerReverseSpeed);
        }

        if(Input.GetKey("d")){
            rigidbody.AddForce(Camera.main.transform.right * playerReverseSpeed);
        }
    }
}
