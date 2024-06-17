using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI playerwinTxt;
    private int p1score = 0;
    private int p2score = 0;

    public AudioSource scoreSound;
    public GameObject gameOverScreen;
    public int pointsToWin = 10;
    // Start is called before the first frame update
   
    void Start()
    {
        Time.timeScale = 1;
        score.text = "0 / 0";
    }

    // Update is called once per frame
    public void UpdateP1Score()
    {
        scoreSound.Play();
        p1score++;
        score.text = p1score.ToString() + " / "+ p2score.ToString();
        if (p1score>=pointsToWin)
        {
            playerwinTxt.text = "Messi wins";
            gameOverScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void UpdateP2Score()
    {
        p2score++;
        scoreSound.Play();
        score.text = p1score.ToString() + " / " + p2score.ToString();
        if (p2score>=pointsToWin)
        {
            playerwinTxt.text = "CR7 wins";
            gameOverScreen.SetActive(true);
            
            Time.timeScale = 0;
        }
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
        
    }
}
