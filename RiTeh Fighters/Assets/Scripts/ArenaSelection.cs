using System;
using UnityEngine;

public class ArenaSelection : MonoBehaviour
{
    public void SelectArena(int selectedArena) {
        // Remove existing PlayerPrefs
        if (PlayerPrefs.HasKey("selectedArena"))
        {
            PlayerPrefs.DeleteKey("selectedArena");
            PlayerPrefs.Save();
        }

        // Save the value using PlayerPrefs
        PlayerPrefs.SetInt("selectedArena", selectedArena);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetInt("selectedArena", 0));
    }

}
