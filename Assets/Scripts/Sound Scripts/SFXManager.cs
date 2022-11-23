using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager newInstance;

    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();

    Hashmap hashmap;

    AudioSource audioSource;

    private void Awake() {
        newInstance = this;
        DontDestroyOnLoad(this.gameObject);

        audioSource = GetComponent<AudioSource>();

        hashmap = new Hashmap();
        
        for(int i = 0; i < audioClips.Count; i++){
            hashmap.AddToHashmap(audioClips[i]);
        }
    }

    public void PlaySound(string soundName){
        AudioClip clip = hashmap.GetValueFromKey(soundName);
        audioSource.PlayOneShot(clip);
    }
}
