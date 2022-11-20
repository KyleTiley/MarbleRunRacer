using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointFinishLine : MonoBehaviour
{
    private SceneChanger sceneChanger;

    private void OnTriggerEnter(Collider other) {
        sceneChanger = FindObjectOfType<SceneChanger>();
        Cursor.lockState = CursorLockMode.None;
        sceneChanger.StartCheckpointWin();
    }
}
