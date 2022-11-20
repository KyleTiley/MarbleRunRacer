using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        CheckpointManager.current.IncreaseTime();
        CheckpointManager.current.PassCheckpoint();
        Destroy(gameObject);
    }
}
