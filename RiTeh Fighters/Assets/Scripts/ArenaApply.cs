using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaApply : MonoBehaviour
{

    //Remember to maybe turn arena images back to active once the battle ends.
    void Start()
    {
        if (PlayerPrefs.GetInt("selectedArena", 0) == 1)
        {
            GameObject.Find("Gameplay_Arena_Image2").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image3").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image4").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image5").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image6").SetActive(false);
        }

        if (PlayerPrefs.GetInt("selectedArena", 0) == 2)
        {
            GameObject.Find("Gameplay_Arena_Image1").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image3").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image4").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image5").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image6").SetActive(false);
        }

        if (PlayerPrefs.GetInt("selectedArena", 0) == 3)
        {
            GameObject.Find("Gameplay_Arena_Image1").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image2").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image4").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image5").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image6").SetActive(false);
        }

        if (PlayerPrefs.GetInt("selectedArena", 0) == 4)
        {
            GameObject.Find("Gameplay_Arena_Image1").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image2").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image3").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image5").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image6").SetActive(false);
        }

        if (PlayerPrefs.GetInt("selectedArena", 0) == 5)
        {
            GameObject.Find("Gameplay_Arena_Image1").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image2").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image3").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image4").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image6").SetActive(false);
        }

        if (PlayerPrefs.GetInt("selectedArena", 0) == 6)
        {
            GameObject.Find("Gameplay_Arena_Image1").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image2").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image3").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image4").SetActive(false);
            GameObject.Find("Gameplay_Arena_Image5").SetActive(false);
        }
    }

}
