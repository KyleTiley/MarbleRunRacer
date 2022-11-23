using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceStartPause : MonoBehaviour
{
    SFXManager sFXManager;

    private void Start() {
        StartCoroutine(StartPause());
        sFXManager = FindObjectOfType<SFXManager>();
        sFXManager.PlaySound("ReadySetGo");
    }

    IEnumerator StartPause(){
        PauseGame();
        yield return new WaitForSecondsRealtime(3);
        ResumeGame();
    }

    void PauseGame(){
        Time.timeScale = 0;
    }

    void ResumeGame(){
        Time.timeScale = 1;
    }
}
