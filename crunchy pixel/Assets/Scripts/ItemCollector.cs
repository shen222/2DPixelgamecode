using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public int biscuits = 0;
    public int highScores = 0;

    [SerializeField] public Text biscuitsText;
    [SerializeField] public Text highscoreText;

    void Start()
    {

        highscoreText.text = $"High Score: {PlayerPrefs.GetInt("highscore ", 0).ToString()}";

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Biscuit"))
        {
            Destroy(collision.gameObject);
            biscuits++;
            biscuitsText.text = "Biscuits: " + biscuits;
        }

        PlayerPrefs.SetInt("HighScore", biscuits);

       
        
    }
}
