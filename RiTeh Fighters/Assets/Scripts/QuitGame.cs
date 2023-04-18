using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This code does not seem to work within the editor to exit the play state. After compiling, it works perfectly within the game.
public class QuitGame : MonoBehaviour
{
    public void Quit() {
        Application.Quit();
    }
}
