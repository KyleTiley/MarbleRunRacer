using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AdvancedAI : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    [SerializeField] Vector3 currentWaypoint;

    GraphManager graphManager;
    GraphNode currentNode;

    public bool lookingForWaypoint = false;

    private void Awake() {
        navMeshAgent = this.GetComponent<NavMeshAgent>();
        graphManager = FindObjectOfType<GraphManager>().GetComponent<GraphManager>();
    }

    private void Start() {
        currentNode = graphManager.graphADT._graphNodes[0];
        currentWaypoint = currentNode._nodePosition;
        MoveAI();
    }

    private void Update() {
        MoveAI();
    }

    private void MoveAI(){
        if(lookingForWaypoint){
            currentNode = graphManager.graphADT.GetNextNode(currentNode);
            currentWaypoint = currentNode._nodePosition;
            lookingForWaypoint = false;
        }
        navMeshAgent.SetDestination(currentWaypoint);
    }
}
