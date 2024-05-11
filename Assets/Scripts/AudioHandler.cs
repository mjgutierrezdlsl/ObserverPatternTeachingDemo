using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioHandler : MonoBehaviour
{
    [SerializeField] AudioClip[] _clips;
    AudioSource _source;

    void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    public void PlayRandomClip()
    {
        _source.PlayOneShot(_clips[Random.Range(0, _clips.Length)]);
    }
}
