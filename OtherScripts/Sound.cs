using UnityEngine.Audio;
using UnityEngine;
//this was made from a tutorial

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
