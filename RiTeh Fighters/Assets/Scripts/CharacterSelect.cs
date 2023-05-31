using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    public GameObject[] objBtn;
    
    private void Start()
    {
        PlayerPrefs.SetInt("player1_character", 0);
        PlayerPrefs.SetInt("player2_character", 0);

    }

    

    public void SelectCharacter_Player1 (int character)
    {
        // Remove existing PlayerPrefs
        if (PlayerPrefs.HasKey("player1_character"))
        {
            PlayerPrefs.DeleteKey("player1_character");
            PlayerPrefs.Save();
        }

        // Save the value using PlayerPrefs
        PlayerPrefs.SetInt("player1_character", character);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetInt("player1_character", 0));

        if (PlayerPrefs.GetInt("player1_character", 0) != 0)
        {
            objBtn = GameObject.FindGameObjectsWithTag("P2_Character");
            for(int i = 0; i < objBtn.Length; i++)
            {
                objBtn[i].GetComponent<CustomButton>().interactable = true;
            }
            objBtn = GameObject.FindGameObjectsWithTag("P1_Character");
            for (int i = 0; i < objBtn.Length; i++)
            {
                objBtn[i].GetComponent<CustomButton>().interactable = false;
            }
        }
    }

    public void SelectCharacter_Player2(int character)
    {
        // Remove existing PlayerPrefs
        if (PlayerPrefs.HasKey("player2_character"))
        {
            PlayerPrefs.DeleteKey("player2_character");
            PlayerPrefs.Save();
        }

        // Save the value using PlayerPrefs
        PlayerPrefs.SetInt("player2_character", character);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetInt("player2_character", 0));

        if(PlayerPrefs.GetInt("player2_character", 0) != 0)
        {
            objBtn = GameObject.FindGameObjectsWithTag("P2_Character");
            for( int i = 0;i < objBtn.Length; i++)
            {
                objBtn[i].GetComponent<CustomButton>().interactable = false;
            }

            objBtn = GameObject.FindGameObjectsWithTag("ConfirmBtn");
            for(int i = 0; i < objBtn.Length; i++)
            {
                objBtn[i].GetComponent<CustomButton>().enabled = true;
                objBtn[i].GetComponent<CustomButton>().interactable = true;
                objBtn[i].GetComponent<ChangeAlpha>().maxAlpha();
                objBtn[i].GetComponentInChildren<TextMeshProUGUI>().alpha = 1;
            }
        }

    }
}
