using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hashmap
{
    List<string> hashKeys;
    List<AudioClip> hashValues;

    public Hashmap(){
        hashKeys = new List<string>();
        hashValues = new List<AudioClip>();
    }

    public void AddToHashmap(AudioClip clip){
        hashKeys.Add(clip.name);
        hashValues.Add(clip);
    }

    public int GetIndexOfKey(string _key){
        int index = hashKeys.IndexOf(_key);
        return index;
    }

    public AudioClip GetValueFromKey(string _key){
        int index = GetIndexOfKey(_key);
        AudioClip audioClip = hashValues[index];
        return audioClip;
    }
}
