using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject howToPlay;
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void ActivateOptions()
    {
        howToPlay.SetActive(true);
    }

    public void DeactivateOptions()
    {
        howToPlay.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
