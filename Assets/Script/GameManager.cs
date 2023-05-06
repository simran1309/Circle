using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject restartButton;
    public bool gameOver;
    public GameObject ScoreText;
    public GameObject DiamondText;
    public GameObject HeadText;
    public Player player;
    public float countTimer = 5;
    public GameObject playerClone;
    public GameObject Playerfront;
    public GameObject Playerback;


    // Start is called before the first frame update
    void Start()
    {
        restartButton.SetActive(false);
        DiamondText.SetActive(false);
        ScoreText.SetActive(false);
        HeadText.SetActive(true);
        playerClone.SetActive(true);
        Playerfront.SetActive(false);
        Playerback.SetActive(false);
        Time.timeScale = 1;
        countTimer = 5;

    }
    public void StartGame()
    {
        restartButton.SetActive(false);
        
        Time.timeScale = 1;
      
        
    }

    // Update is called once per frame
    void Update()
    {if (gameOver){
            countTimer -= Time.unscaledDeltaTime;
            GameOver();
        }
   
      if (player.play)
        {
            playerClone.SetActive(false);
            Playerfront.SetActive(true);
            Playerback.SetActive(true);
            ScoreText.SetActive(true);
            HeadText.SetActive(false);
        }
    }
    public void GameOver()
    {

            Time.timeScale = 0;
        //gameOver = true;
        if (countTimer < 2)
        {
            RestartGame();
        }

    }


    public void RestartGame()
    {
        DiamondText.SetActive(true);
        restartButton.SetActive(true);
        ScoreText.SetActive(false);

    }
    public void ResetGame()
    {
        
        SceneManager.LoadScene("Gameplay");

    }
}
