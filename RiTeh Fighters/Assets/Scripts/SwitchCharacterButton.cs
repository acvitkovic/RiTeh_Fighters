using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCharacterButton : MonoBehaviour
{
    public int doItOnce = 0;
    void Update()
    {
        if (GameObject.Find("P1_Container").GetComponentInChildren<CustomButton>().IsInteractable() == false && doItOnce == 0)
        {
            GameObject.Find("P2_C1Btn").GetComponent<CustomButton>().Select();
            doItOnce++;
        }
    }
}
