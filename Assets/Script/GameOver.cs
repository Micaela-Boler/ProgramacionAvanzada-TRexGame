using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public ScoreManager highScore;
    [SerializeField] TextMeshProUGUI finalScore;

    void Start()
    {
        gameObject.SetActive(false);
    }


    public void activeScreen()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;

        highScore.HighScoreUpdate();
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
