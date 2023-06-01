using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharSelectControllerBehavior : MonoBehaviour
{
   //private int disable_flag = 0; 
        //0 - P1 enabled, P2 disabled
        //1 - P1 disable, P2 enabled
        //2 - both enabled
    void Update()
    {
        /* WIP 
        if (!GameObject.FindGameObjectWithTag("P1_Character").GetComponent<CustomButton>().IsInteractable())
        {
            disable_flag = 1;
        }
        else
        {
            disable_flag = 0;
        }

        if (disable_flag == 0)
        {
            InputSystem.DisableDevice(Gamepad.all[1]);
            InputSystem.EnableDevice(Gamepad.all[0]);
        } else if (disable_flag == 1)
        {
            InputSystem.DisableDevice(Gamepad.all[0]);
            InputSystem.EnableDevice(Gamepad.all[1]);
        }
        */
    }
}
