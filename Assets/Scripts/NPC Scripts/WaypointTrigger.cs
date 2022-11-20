using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointTrigger : MonoBehaviour
{
    AIController aIController;
    PlayerController playerController;
    //[SerializeField] PlacementController placementController;

    private void OnTriggerEnter(Collider other) {
        // if(other.tag != "Player"){
        //     aIController = other.gameObject.GetComponent<AIController>();
        //     aIController.lookingForWaypoint = true;
        //     aIController.checkpointsPassed++;
        //     aIController.timerStart = true;
        // }
        // if(other.tag == "Player"){
        //     playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        //     playerController.playerCheckpointsPassed++;
        //     placementController.CompareScores();
        //     playerController.playerTimer = true;
        // }
    }
}
