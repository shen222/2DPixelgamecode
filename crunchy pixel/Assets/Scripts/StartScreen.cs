using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartScreen : MonoBehaviour
{

   
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("LoadScreen");
    }

    public void LoadHelpScene()
    {
        SceneManager.LoadScene("HelpScene");
    }
}
