using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

// Referenced from: https://youtu.be/DU7cgVsU2rM?si=XYQkIn62Dah-KVGw
public class SoundMixerManager : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;
    public void SetMasterVolume(float level)
    {
        // Corrects volume curve to be a value between 0.0001 and 1
        var correctedLevel = Mathf.Log10(level) * 20f;
        _audioMixer.SetFloat("masterVolume", correctedLevel);
    }
    public void SetMusicVolume(float level)
    {
        var correctedLevel = Mathf.Log10(level) * 20f;
        _audioMixer.SetFloat("musicVolume", correctedLevel);
    }
    public void SetSFXVolume(float level)
    {
        var correctedLevel = Mathf.Log10(level) * 20f;
        _audioMixer.SetFloat("sfxVolume", correctedLevel);
    }
}
