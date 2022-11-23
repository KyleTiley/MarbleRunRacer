using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectatorController : MonoBehaviour
{
    [SerializeField]private Animator animator;

    private const string CHEER_ANIMATION_BOOL = "shouldCheer";
    private const string WAVE_ANIMATION_BOOL = "shouldWave";
    private const string SHAKE_ANIMATION_BOOL = "shouldShake";

    private void Awake() {
        animator = transform.GetChild(0).GetComponent<Animator>();
    }

    private void Animate(string boolName){
        DisableOtherAnimations(animator, boolName);
        animator.SetBool(boolName, true);
    }

    private void DisableOtherAnimations(Animator animator, string animation){
        foreach(AnimatorControllerParameter parameter in animator.parameters){
            if(parameter.name != animation){
                animator.SetBool(parameter.name, false);
            }
        }
    }

    public void AnimateCheer(){
        Animate(CHEER_ANIMATION_BOOL);
    }

    public void AnimateWave(){
        Animate(WAVE_ANIMATION_BOOL);
    }
    
    public void AnimateShake(){
        Animate(SHAKE_ANIMATION_BOOL);
    }
}
