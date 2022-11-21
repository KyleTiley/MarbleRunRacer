using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphEdge
{
    GraphNode startingNode;
    public GraphNode _startingNode{
        get => startingNode;
        set => startingNode = value;
    }

    GraphNode endingNode;
    public GraphNode _endingNode{
        get => endingNode;
        set => endingNode = value;
    }
}
