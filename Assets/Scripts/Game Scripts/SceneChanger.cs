using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void GoToMenu(){
        SceneManager.LoadScene(0);
    }

    public void StartCheckpointRace(){
        SceneManager.LoadScene(1);
    }

    public void StartBeginnerRace(){
        SceneManager.LoadScene(2);
    }

    public void StartAdvancedRace(){
        SceneManager.LoadScene(3);
    }

    public void StartCheckpointDialogue(){
        SceneManager.LoadScene(4);
    }

    public void StartBeginnerDialogue(){
        SceneManager.LoadScene(5);
    }

    public void StartAdvancedDialogue(){
        SceneManager.LoadScene(6);
    }

    public void StartCheckpointWin(){
        SceneManager.LoadScene(7);
    }

    public void StartCheckpointLose(){
        SceneManager.LoadScene(8);
    }

    public void StartBeginnerFinish(){
        SceneManager.LoadScene(9);
    }

    public void StartAdvancedFinish(){
        SceneManager.LoadScene(10);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
