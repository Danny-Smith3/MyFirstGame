using UnityEngine.Audio;
using UnityEngine;
//this was made from a tutorial; the tutorial is: Introduction to AUDIO in Unity by Brackeys
//this a script for one specific sound that could go inside the audio manager

[System.Serializable]
public class Sound {

    public AudioClip clip;


    public float pitch;
    [Range(0f, 1f)]
    public float volume;
    public string name;
    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
