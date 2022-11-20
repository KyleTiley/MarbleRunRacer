using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManagement : MonoBehaviour
{
    public Transform[] Waypoints;
    LinkedList<Transform> waypointsLL = new LinkedList<Transform>();
    Transform currentWaypoint;

    private void Awake() {
        waypointsLL = new LinkedList<Transform>(Waypoints);
        currentWaypoint = waypointsLL.First.Value;
    }

    public Transform GetFirstWaypoint(){
        return currentWaypoint;
    }

    public Transform GetNextWaypoint(Transform _currentWaypoint){
        if(_currentWaypoint == null || _currentWaypoint == waypointsLL.Last.Value){
            currentWaypoint = waypointsLL.First.Value;
        }
        else{
            currentWaypoint = waypointsLL.Find(_currentWaypoint).Next.Value;
        }
        return currentWaypoint;
    }
}
