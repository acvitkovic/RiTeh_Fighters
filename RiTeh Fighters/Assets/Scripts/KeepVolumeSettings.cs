using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepVolumeSettings : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("affirmativeSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);
        GameObject.Find("nopeSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);
        GameObject.Find("switchingSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);
    }
}
