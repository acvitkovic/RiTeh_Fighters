using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void GoToMainMenu() {
        SceneManager.LoadScene("GameMenu");
        GameObject[] tmpMusic = GameObject.FindGameObjectsWithTag("PreviousSceneMusic");
        Destroy(tmpMusic[0]);
    }
    public void GoToArena() {
        SceneManager.LoadScene("ArenaSelect");
    }

    public void GoToCharacterSelect() {
        SceneManager.LoadScene("CharacterSelect");
    }

    public void GotoGameplay()
    {
        GameObject[] tmpMusic = GameObject.FindGameObjectsWithTag("PreviousSceneMusic");
        Destroy(tmpMusic[0]);
        SceneManager.LoadScene("GameplayScene");
    }
}
