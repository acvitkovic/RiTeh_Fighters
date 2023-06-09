using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterApply : MonoBehaviour
{
    void Start()
    {
        if ((PlayerPrefs.GetInt("player1_character", 0) == 1)){
            GameObject.Find("P1_CharacterFrame2").SetActive(false);
            GameObject.Find("P1_CharacterFrame3").SetActive(false);
            GameObject.Find("P1_CharacterFrame4").SetActive(false);
            GameObject.Find("P1_CharacterFrame5").SetActive(false);
            GameObject.Find("P1_CharacterFrame6").SetActive(false);
            GameObject.Find("P1_CharacterFrame7").SetActive(false);
            GameObject.Find("P1_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player1_character", 0) == 2))
        {
            GameObject.Find("P1_CharacterFrame1").SetActive(false);
            GameObject.Find("P1_CharacterFrame3").SetActive(false);
            GameObject.Find("P1_CharacterFrame4").SetActive(false);
            GameObject.Find("P1_CharacterFrame5").SetActive(false);
            GameObject.Find("P1_CharacterFrame6").SetActive(false);
            GameObject.Find("P1_CharacterFrame7").SetActive(false);
            GameObject.Find("P1_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player1_character", 0) == 3))
        {
            GameObject.Find("P1_CharacterFrame1").SetActive(false);
            GameObject.Find("P1_CharacterFrame2").SetActive(false);
            GameObject.Find("P1_CharacterFrame4").SetActive(false);
            GameObject.Find("P1_CharacterFrame5").SetActive(false);
            GameObject.Find("P1_CharacterFrame6").SetActive(false);
            GameObject.Find("P1_CharacterFrame7").SetActive(false);
            GameObject.Find("P1_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player1_character", 0) == 4))
        {
            GameObject.Find("P1_CharacterFrame1").SetActive(false);
            GameObject.Find("P1_CharacterFrame2").SetActive(false);
            GameObject.Find("P1_CharacterFrame3").SetActive(false);
            GameObject.Find("P1_CharacterFrame5").SetActive(false);
            GameObject.Find("P1_CharacterFrame6").SetActive(false);
            GameObject.Find("P1_CharacterFrame7").SetActive(false);
            GameObject.Find("P1_CharacterFrame8").SetActive(false);
        }

        if ((PlayerPrefs.GetInt("player1_character", 0) == 5))
        {
            GameObject.Find("P1_CharacterFrame1").SetActive(false);
            GameObject.Find("P1_CharacterFrame2").SetActive(false);
            GameObject.Find("P1_CharacterFrame3").SetActive(false);
            GameObject.Find("P1_CharacterFrame4").SetActive(false);
            GameObject.Find("P1_CharacterFrame6").SetActive(false);
            GameObject.Find("P1_CharacterFrame7").SetActive(false);
            GameObject.Find("P1_CharacterFrame8").SetActive(false);
        }

        if ((PlayerPrefs.GetInt("player1_character", 0) == 6))
        {
            GameObject.Find("P1_CharacterFrame1").SetActive(false);
            GameObject.Find("P1_CharacterFrame2").SetActive(false);
            GameObject.Find("P1_CharacterFrame3").SetActive(false);
            GameObject.Find("P1_CharacterFrame4").SetActive(false);
            GameObject.Find("P1_CharacterFrame5").SetActive(false);
            GameObject.Find("P1_CharacterFrame7").SetActive(false);
            GameObject.Find("P1_CharacterFrame8").SetActive(false);
        }

        if ((PlayerPrefs.GetInt("player1_character", 0) == 7))
        {
            GameObject.Find("P1_CharacterFrame1").SetActive(false);
            GameObject.Find("P1_CharacterFrame2").SetActive(false);
            GameObject.Find("P1_CharacterFrame3").SetActive(false);
            GameObject.Find("P1_CharacterFrame4").SetActive(false);
            GameObject.Find("P1_CharacterFrame5").SetActive(false);
            GameObject.Find("P1_CharacterFrame6").SetActive(false);
            GameObject.Find("P1_CharacterFrame8").SetActive(false);
        }

        if ((PlayerPrefs.GetInt("player1_character", 0) == 8))
        {
            GameObject.Find("P1_CharacterFrame1").SetActive(false);
            GameObject.Find("P1_CharacterFrame2").SetActive(false);
            GameObject.Find("P1_CharacterFrame3").SetActive(false);
            GameObject.Find("P1_CharacterFrame4").SetActive(false);
            GameObject.Find("P1_CharacterFrame5").SetActive(false);
            GameObject.Find("P1_CharacterFrame6").SetActive(false);
            GameObject.Find("P1_CharacterFrame7").SetActive(false);
        }

        /////////////////////////////////////
        ///
        if ((PlayerPrefs.GetInt("player2_character", 0) == 1))
        {
            GameObject.Find("P2_CharacterFrame2").SetActive(false);
            GameObject.Find("P2_CharacterFrame3").SetActive(false);
            GameObject.Find("P2_CharacterFrame4").SetActive(false);
            GameObject.Find("P2_CharacterFrame5").SetActive(false);
            GameObject.Find("P2_CharacterFrame6").SetActive(false);
            GameObject.Find("P2_CharacterFrame7").SetActive(false);
            GameObject.Find("P2_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player2_character", 0) == 2))
        {
            GameObject.Find("P2_CharacterFrame1").SetActive(false);
            GameObject.Find("P2_CharacterFrame3").SetActive(false);
            GameObject.Find("P2_CharacterFrame4").SetActive(false);
            GameObject.Find("P2_CharacterFrame5").SetActive(false);
            GameObject.Find("P2_CharacterFrame6").SetActive(false);
            GameObject.Find("P2_CharacterFrame7").SetActive(false);
            GameObject.Find("P2_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player2_character", 0) == 3))
        {
            GameObject.Find("P2_CharacterFrame1").SetActive(false);
            GameObject.Find("P2_CharacterFrame2").SetActive(false);
            GameObject.Find("P2_CharacterFrame4").SetActive(false);
            GameObject.Find("P2_CharacterFrame5").SetActive(false);
            GameObject.Find("P2_CharacterFrame6").SetActive(false);
            GameObject.Find("P2_CharacterFrame7").SetActive(false);
            GameObject.Find("P2_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player2_character", 0) == 4))
        {
            GameObject.Find("P2_CharacterFrame1").SetActive(false);
            GameObject.Find("P2_CharacterFrame2").SetActive(false);
            GameObject.Find("P2_CharacterFrame3").SetActive(false);
            GameObject.Find("P2_CharacterFrame5").SetActive(false);
            GameObject.Find("P2_CharacterFrame6").SetActive(false);
            GameObject.Find("P2_CharacterFrame7").SetActive(false);
            GameObject.Find("P2_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player2_character", 0) == 5))
        {
            GameObject.Find("P2_CharacterFrame1").SetActive(false);
            GameObject.Find("P2_CharacterFrame2").SetActive(false);
            GameObject.Find("P2_CharacterFrame3").SetActive(false);
            GameObject.Find("P2_CharacterFrame4").SetActive(false);
            GameObject.Find("P2_CharacterFrame6").SetActive(false);
            GameObject.Find("P2_CharacterFrame7").SetActive(false);
            GameObject.Find("P2_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player2_character", 0) == 6))
        {
            GameObject.Find("P2_CharacterFrame1").SetActive(false);
            GameObject.Find("P2_CharacterFrame2").SetActive(false);
            GameObject.Find("P2_CharacterFrame3").SetActive(false);
            GameObject.Find("P2_CharacterFrame4").SetActive(false);
            GameObject.Find("P2_CharacterFrame5").SetActive(false);
            GameObject.Find("P2_CharacterFrame7").SetActive(false);
            GameObject.Find("P2_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player2_character", 0) == 7))
        {
            GameObject.Find("P2_CharacterFrame1").SetActive(false);
            GameObject.Find("P2_CharacterFrame2").SetActive(false);
            GameObject.Find("P2_CharacterFrame3").SetActive(false);
            GameObject.Find("P2_CharacterFrame4").SetActive(false);
            GameObject.Find("P2_CharacterFrame5").SetActive(false);
            GameObject.Find("P2_CharacterFrame6").SetActive(false);
            GameObject.Find("P2_CharacterFrame8").SetActive(false);
        }
        if ((PlayerPrefs.GetInt("player2_character", 0) == 8))
        {
            GameObject.Find("P2_CharacterFrame1").SetActive(false);
            GameObject.Find("P2_CharacterFrame2").SetActive(false);
            GameObject.Find("P2_CharacterFrame3").SetActive(false);
            GameObject.Find("P2_CharacterFrame4").SetActive(false);
            GameObject.Find("P2_CharacterFrame5").SetActive(false);
            GameObject.Find("P2_CharacterFrame6").SetActive(false);
            GameObject.Find("P2_CharacterFrame7").SetActive(false);
        }

    }

}
