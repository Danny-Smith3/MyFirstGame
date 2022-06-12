using UnityEngine.Audio;
using UnityEngine;
//this was made partially with a tutorial; the tutorial is : Introduction to AUDIO in Unity by Brackeys
//is an audio manager that allows me to play a specific sound from multiple sounds attached to one object

public class AudioManager : MonoBehaviour {

    public Sound[] sounds;

    void Awake() {
        foreach (Sound s in sounds) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.spatialBlend = 1f;
            s.source.rolloffMode = AudioRolloffMode.Linear;
            if (s.name == "Walk") {
                s.source.maxDistance = 100f;
                s.source.minDistance = 15f;
            } else if (s.name == "Reload") {
                s.source.maxDistance = 30f;
            } else if (s.name == "Shoot") {
                s.source.maxDistance = 90f;
            }
        }
    }

    public void playSound(string name) {
        foreach (Sound s in sounds) {
            if (s.name == name) {
                s.source.Play();
            }
        }
    }

    public void stopSound(string name) {
        foreach (Sound s in sounds) {
            if (s.name == name) {
                s.source.Stop();
            }
        }
    }
}
