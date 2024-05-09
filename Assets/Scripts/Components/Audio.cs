using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Components
{
    public class Audio : MonoBehaviour
    {
        AudioSource _source;
        void Awake()
        {
            _source = FindObjectOfType<AudioSource>();
        }
        public void PlayRandomClip(AudioClip[] clips)
        {
            _source.PlayOneShot(clips[Random.Range(0, clips.Length)]);
        }
        public void PlayRandomClip(AudioClip[] clips, float delay)
        {
            _source.clip = clips[Random.Range(0, clips.Length)];
            _source.PlayDelayed(delay);
        }
    }

}