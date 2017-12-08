using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static SoundManager instance = null;

    void Awake()
    {
        //Check for an instance of SoundManager
        if (instance == null)
        {
            //if it is null
            instance = this;
        }
        //if instance already exists
        else if (instance != null)
        {
            //destroy this to enforce our singelton pattern so there can only be one instance of sound manager
            Destroy(gameObject);
        }
        //Keeps the sound manager from being destroyed between scenes
        DontDestroyOnLoad(gameObject);
    }

    public void PlayOneShoot(bool randPitch ,params AudioClip [] clips)
    {
        AudioClip clipToPlay;
        float clipPitch;
        //Checks if there is multiple clips, creates a random number and uses it to select a random clip
        if (clips.Length > 0)
        {
            int randClip = Random.Range(0, clips.Length);
            clipToPlay = clips[randClip];
        }
        //If there is only 1 clip, select that 1 clip 
        //(this is almost usesless tho. If there was only 1 clip it would randomly shoose it every time)
        else
        {
            clipToPlay = clips[0];
        }
        //checks to see if a random pitch is wanted
        if (randPitch == true)
        {
            float upperPitch = 1.05f;
            float lowerPitch = .95f;

            clipPitch = Random.Range(lowerPitch, upperPitch);
        }
        else
        {
            clipPitch = 1;
        }
        AudioSource myAudioSource = GetComponent<AudioSource>();
        myAudioSource.clip = clipToPlay;
        myAudioSource.pitch = clipPitch;
        myAudioSource.Play();
    }

}
