using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckpointTimer : MonoBehaviour
{
    public float timeLeft = 10;
    public bool timerOn = false;

    public TextMeshProUGUI timerText;
    private SceneChanger sceneChanger;

    private void Start() {
        timerOn = true;
    }

    private void FixedUpdate() {
        if(timerOn){
            if(timeLeft > 0){
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
            }
            else{
                timerOn = false;
                timeLeft = 0;
                sceneChanger = FindObjectOfType<SceneChanger>();
                Cursor.lockState = CursorLockMode.None;
                sceneChanger.StartCheckpointLose();
            }
        }
    }

    void UpdateTimer(float currentTime){
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
