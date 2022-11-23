using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spectator : MonoBehaviour
{
    [SerializeField] SpectatorController animator;

    private void Start() {
        StartCoroutine(DoAnimation());
    }

    IEnumerator DoAnimation(){
        while(true){
            int mainRand = Random.Range(0,3);
            int time = Random.Range(5,10);
            if(mainRand == 0){
                animator.AnimateWave();
            }
            else if(mainRand == 1){
                animator.AnimateCheer();
            }
            else if(mainRand == 2){
                animator.AnimateShake();
            }
            yield return new WaitForSeconds(time);
        }
    }
}
