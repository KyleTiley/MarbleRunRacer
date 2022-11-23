using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTriggerSound : MonoBehaviour
{
    int lapCount = 0;
    SFXManager sFXManager;
    SceneChanger sceneChanger;

    private void Awake() {
        sFXManager = FindObjectOfType<SFXManager>();
        sceneChanger = FindObjectOfType<SceneChanger>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            lapCount++;
            
            if(lapCount == 4){
                Cursor.lockState = CursorLockMode.None;
                sceneChanger.StartAdvancedFinish();
            }
            else if(lapCount > 1){
                sFXManager.PlaySound("LapComplete");
            }
        }
    }
}
