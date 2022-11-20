using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    // [SerializeField] WaypointManagement waypoinsLL;
    // [SerializeField] PlacementController placementController;
    [SerializeField] NavMeshAgent thisAgent;
    [SerializeField] Transform currentWaypoint;
    //public int checkpointsPassed = 0;
    //public bool timerStart = false;

    public bool lookingForWaypoint = false;

    private void Awake() {
        //waypoinsLL = GameObject.Find("WaypointManager").GetComponent<WaypointManagement>();
        //placementController = GameObject.Find("UIManager").GetComponent<PlacementController>();
        thisAgent = GetComponent<NavMeshAgent>();
        // currentWaypoint = waypoinsLL.GetFirstWaypoint();
        MoveAgent();
    }

    private void Update() {
        MoveAgent();
    }

    private void MoveAgent(){
        // if(lookingForWaypoint){
        //     currentWaypoint = waypoinsLL.GetNextWaypoint(currentWaypoint);
        //     lookingForWaypoint = false;
        // }
        thisAgent.SetDestination(currentWaypoint.position);
    }
}
