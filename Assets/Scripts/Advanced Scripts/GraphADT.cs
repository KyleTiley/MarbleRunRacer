using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphADT
{
    // Nodes in the GraphADT
    List<GraphNode> graphNodes;
    public List<GraphNode> _graphNodes{
        get => graphNodes;
        set => graphNodes = value;
    }

    // Edges in the GraphADT
    List<GraphEdge> graphEdges;
    public List<GraphEdge> _graphEdges{
        get => graphEdges;
        set => graphEdges = value;
    }

    public GraphADT(){
        graphNodes = new List<GraphNode>();
        graphEdges = new List<GraphEdge>();
    }

    //Call this each times the AI racer enters a waypoint trigger
    public GraphNode GetNextNode(GraphNode currentNode){
        List<int> edgeIndex = new List<int>();

        for(int i = 0; i < _graphEdges.Count; i++){
            if(_graphEdges[i]._startingNode == currentNode){
                edgeIndex.Add(i);
            }
        }

        if(edgeIndex.Count > 1){
            int randomPath = Random.Range(0, edgeIndex.Count);
            return _graphEdges[edgeIndex[randomPath]]._endingNode;
        }
        else{
            return _graphEdges[edgeIndex[0]]._endingNode;
        }
    }
}
