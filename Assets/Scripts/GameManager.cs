using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   public static GameManager instance;
    public int score;
    public TMP_Text scoreText;
    public GameObject gameOverPanel;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Time.timeScale = 1;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }
    public void onClickPlayAgain()
    {
        SceneManager.LoadScene(0);
    }
    public void onClickExit()
    {
        Application.Quit();
    }
}
