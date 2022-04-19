using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private bool isDead = false;
    public GameOver gameOver;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
            return;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Gift")
        {
            score += 2;
        }
        if (other.tag == "Special")
        {
            score += 10;
            
        }
        scoreText.text = " " + score;
        Destroy(other.gameObject);
    }

    public void OnDeath()
    {
        isDead = true;
        //PlayerPrefs.SetFloat("Highscore", score);
        gameOver.ToggleEndMenu(score);
    }

}
