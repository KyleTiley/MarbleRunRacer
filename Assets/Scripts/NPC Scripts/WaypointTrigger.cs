using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointTrigger : MonoBehaviour
{
    AdvancedAI advancedAI;
    //PlayerController playerController;
    //[SerializeField] PlacementController placementController;

    private void OnTriggerEnter(Collider other) {
        if(other.tag != "Player"){
            advancedAI = other.gameObject.GetComponent<AdvancedAI>();
            advancedAI.lookingForWaypoint = true;
            // advancedAI.checkpointsPassed++;
            // advancedAI.timerStart = true;
        }
        if(other.tag == "Player"){
            // do nothing for now
            // playerController = GameObject.Find("Player").GetComponent<PlayerController>();
            // playerController.playerCheckpointsPassed++;
            // placementController.CompareScores();
            // playerController.playerTimer = true;
        }
    }
}
