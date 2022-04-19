using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    public int score;
    public Text highscoreText;
    // Start is called before the first frame update
    void Start()
    {
        highscoreText.text = "Highscore : " + ((int)PlayerPrefs.GetFloat("Highscore", score)).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
