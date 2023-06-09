using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class VolumeControl : MonoBehaviour
{

    public float MusicVolume = 0.5f;
    public float SFXVolume = 0.5f;
    void Update()
    {

        MusicVolume = GameObject.Find("Music_Slider").GetComponent<Slider>().value;
        SFXVolume = GameObject.Find("SFX_Slider").GetComponent <Slider>().value;
        PlayerPrefs.SetFloat("MusicVolume", MusicVolume);
        PlayerPrefs.SetFloat("SFXVolume", SFXVolume);


        GameObject.Find("MainMenuTheme").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume", 0);
        GameObject.Find("affirmativeSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);
        GameObject.Find("nopeSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);
        GameObject.Find("switchingSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);

        PlayerPrefs.Save();
    }

    private void Start()
    {

        GameObject.Find("Music_Slider").GetComponent<Slider>().value = PlayerPrefs.GetFloat("MusicVolume", 0);
        GameObject.Find("SFX_Slider").GetComponent<Slider>().value = PlayerPrefs.GetFloat("SFXVolume", 0);

        GameObject.Find("MainMenuTheme").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("MusicVolume", 0);
        GameObject.Find("affirmativeSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);
        GameObject.Find("nopeSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);
        GameObject.Find("switchingSFX").GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("SFXVolume", 0);
    }
}



