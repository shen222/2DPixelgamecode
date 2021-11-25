using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    

    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource deathSoundEffect;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Deathbox"))
        {
            Die();
        }
    }

   
    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");

        HighscoreEvent();
    }

    private void HighscoreEvent()
    {
        int highscore = PlayerPrefs.GetInt("HighScore", 0);

        if(ItemCollector.biscuits > highscore) 
        {
            PlayerPrefs.SetInt("HighScore", ItemCollector.biscuits);
        }
    }

    private void RestartLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Game");
    }


}
