using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    // Scriptable object holding dialogue
    [SerializeField] DialogueObject dialogueObject;

    // UI components
    [SerializeField] TextMeshProUGUI textCompomponent;
    [SerializeField] float textSpeed;
    public GameObject startRaceButton;
    private int nextLineIndex;
    private bool isNextLine;
    [SerializeField] GameObject yourSpeechArrow;
    [SerializeField] GameObject otherSpeechArrow;

    // Queue for dialogue
    Queue<string> dialogueQueue = new Queue<string>();
    private string nextDialogue;

    private void Start(){
        textCompomponent.text = string.Empty;
        QueueDialogue();
        StartDialogue();
    }

    // Checks for mouse press to go to next dialogue
    // Also allows player to skip scrolling text and just see dialogue
    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            if(textCompomponent.text == dialogueObject.dialogueLines[nextLineIndex]){
                NextLine();
            }
            else{
                StopAllCoroutines();
                textCompomponent.text = dialogueObject.dialogueLines[nextLineIndex];
            }
        }
    }

    // Queues up dialogue, loaded from scriptable object
    void QueueDialogue(){
        for (int i = 0; i < dialogueObject.dialogueLines.Length; i++){
            dialogueQueue.Enqueue(dialogueObject.dialogueLines[i]);
        }
    }

    // Starts the dialogue
    public void StartDialogue(){
        nextLineIndex = 0;
        isNextLine = true;
        StartCoroutine(DisplayDialogue());
    }

    // Displays the dialogue, line by line
    IEnumerator DisplayDialogue(){
        if(dialogueQueue.Count !=0 && isNextLine == true){
            nextDialogue = dialogueQueue.Dequeue();
            // Checks who is speaking
            if(nextDialogue.Contains("You")){
                yourSpeechArrow.SetActive(true);
                otherSpeechArrow.SetActive(false);
            }
            else{
                yourSpeechArrow.SetActive(false);
                otherSpeechArrow.SetActive(true);
            }

            // Types out dialogue at a slow pace, looks nice  i think :)
            foreach(char c in nextDialogue){
                textCompomponent.text += c;
                yield return new WaitForSeconds(textSpeed);
            }
            isNextLine = false;
        }
    }

    // Goes to next line of dialogue, and changes scene when dialogue is over
    void NextLine(){
        if(nextLineIndex < dialogueObject.dialogueLines.Length - 1){
            nextLineIndex++;
            isNextLine = true;
            textCompomponent.text = string.Empty;
            StartCoroutine(DisplayDialogue());
        }
        else{
            enableButton();
        }
    }

    // Enables the start race button
    public void enableButton(){
        startRaceButton.SetActive(true);
    }
}
