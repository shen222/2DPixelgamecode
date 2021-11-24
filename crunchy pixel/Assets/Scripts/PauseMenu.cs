using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pausemenu;
    
    public void pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MainMenu(int sceneID)
    {
        SceneManager.LoadScene("Start Screen");
    }
}
