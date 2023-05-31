using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToMainMenu() {
        SceneManager.LoadScene("GameMenu");
    }
    public void GoToArena() {
        SceneManager.LoadScene("ArenaSelect");
    }

    public void GoToCharacterSelect() {
        SceneManager.LoadScene("CharacterSelect");
    }

    public void GotoGameplay()
    {
        SceneManager.LoadScene("GameplayScene");
    }
}
