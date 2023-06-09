using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaVolume : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Gameplay_Arena_Image1").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume", 0);
        GameObject.Find("Gameplay_Arena_Image2").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume", 0);
        GameObject.Find("Gameplay_Arena_Image3").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume", 0);
        GameObject.Find("Gameplay_Arena_Image4").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume", 0);
    }
}
