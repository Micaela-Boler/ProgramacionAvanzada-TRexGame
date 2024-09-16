using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("SCORE")]
    [SerializeField] TextMeshProUGUI scoreText;
    private int score = 0;

    [Header("BEST SCORE")]
    [SerializeField] TextMeshProUGUI highScoreText;



    public void UpdateScore()
    {
        score++;
        scoreText.text = (score).ToString("0");
    }

    public void HighScoreUpdate()
    {
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (score > PlayerPrefs.GetInt("SavedHighScore"))
                PlayerPrefs.SetInt("SavedHighScore", score);
        }
        else
        {
            PlayerPrefs.SetInt("SavedHighScore", score);
        }
            
        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString(); 
    }
    
}
