using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0.0f, 1.0f)]
    public float volume;

    [Range(0.1f, 0.3f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource source;
}
