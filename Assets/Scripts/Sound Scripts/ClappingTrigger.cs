using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClappingTrigger : MonoBehaviour
{
    SFXManager sFXManager;

    private void Awake() {
        sFXManager = FindObjectOfType<SFXManager>();
    }

    private void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            sFXManager.PlaySound("Clapping");
        }
    }
}
