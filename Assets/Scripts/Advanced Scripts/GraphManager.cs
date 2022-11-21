using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphManager : MonoBehaviour
{
    public GraphADT graphADT;

    [SerializeField] List<Transform> waypoints = new List<Transform>();

    private void Awake() {
        graphADT = new GraphADT();

        CreateNodes();
        CreateEdges();
    }

    //Creates a node for each waypoint in the list
    void CreateNodes(){
        for(int i = 0; i < waypoints.Count; i++){
            GraphNode graphNode = new GraphNode(){ _nodePosition = waypoints[i].position };
            graphADT._graphNodes.Add(graphNode);
        }
    }

    //Manual creation of edges based on which 2 nodes we want the edge to be between
    void CreateEdges(){
        //Start of first two branches
        GraphEdge edge1a = new GraphEdge() { _startingNode = graphADT._graphNodes[0], _endingNode = graphADT._graphNodes[1] };
        GraphEdge edge1b = new GraphEdge() { _startingNode = graphADT._graphNodes[0], _endingNode = graphADT._graphNodes[2] };
        //End of first two branches
        GraphEdge edge2a = new GraphEdge() { _startingNode = graphADT._graphNodes[1], _endingNode = graphADT._graphNodes[3] };
        GraphEdge edge2b = new GraphEdge() { _startingNode = graphADT._graphNodes[2], _endingNode = graphADT._graphNodes[3] };
        //Straight track between the two sets of branches
        GraphEdge edge3 = new GraphEdge() { _startingNode = graphADT._graphNodes[3], _endingNode = graphADT._graphNodes[4] };
        //Start of second two branches
        GraphEdge edge4a = new GraphEdge() { _startingNode = graphADT._graphNodes[4], _endingNode = graphADT._graphNodes[5] };
        GraphEdge edge4b = new GraphEdge() { _startingNode = graphADT._graphNodes[4], _endingNode = graphADT._graphNodes[6] };
        //End of second two branches
        GraphEdge edge5a = new GraphEdge() { _startingNode = graphADT._graphNodes[5], _endingNode = graphADT._graphNodes[7] };
        GraphEdge edge5b = new GraphEdge() { _startingNode = graphADT._graphNodes[6], _endingNode = graphADT._graphNodes[7] };
        //Straight track between last and first checkpoint, going over finish line
        GraphEdge edge6 = new GraphEdge() { _startingNode = graphADT._graphNodes[7], _endingNode = graphADT._graphNodes[0] };

        //Adds all the created edges to a list
        graphADT._graphEdges = new List<GraphEdge>() { edge1a, edge1b, edge2a, edge2b, edge3, edge4a, edge4b, edge5a, edge5b, edge6 };
    }
}
