using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueObject", menuName = "Scriptable Objects", order = 0)]

public class DialogueObject : ScriptableObject{
    // Holds lines of dialogue
    public string[] dialogueLines;
}
