using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    public static CheckpointManager current;
    [SerializeField] CheckpointTimer checkpointTimer;
    [SerializeField] GameObject finishLine;
    private GameObject nextCheckpoint;
    
    Stack checkpointStack = new Stack();
    [SerializeField] GameObject[] allCheckpoints;

    private void Awake() {
        if(current == null){
            current = this;
        }
        else{
            Destroy(gameObject);
        }
    }
    
    private void Start() {
        StackCheckpoint();
        nextCheckpoint = checkpointStack.Peek() as GameObject;
        nextCheckpoint.SetActive(true);
    }

    // Adds time fo each checkpoint passed
    public void IncreaseTime(){
        checkpointTimer.timeLeft += 3;
    }

    void StackCheckpoint(){
        for (int i = 0; i < allCheckpoints.Length; i++){
            checkpointStack.Push(allCheckpoints[i]);
        }
    }

    public void PassCheckpoint(){
        if(checkpointStack.Count == 1){
            finishLine.SetActive(true);
        }
        else{
            checkpointStack.Pop();
            nextCheckpoint = checkpointStack.Peek() as GameObject;
            nextCheckpoint.SetActive(true);
        }
    }
}
