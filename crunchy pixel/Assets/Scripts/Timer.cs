using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeValue = 180;
    public Text timeText;
    public GameObject gameOverPanel;

    public static bool isGameOver;

    private void Start()
    {
        isGameOver = false;
        Time.timeScale = 1;
    }

    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            //timeout
            timeValue = 0;
            isGameOver = true;
        }

        DisplayTime(timeValue);

        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
            StartCoroutine(GameOver());
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }


        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("gameover");
        Time.timeScale = 0;
        yield return null;
    }

}
