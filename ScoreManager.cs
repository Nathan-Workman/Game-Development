using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int player1Score = 0;
    private int player2Score = 0;
    private int player3Score = 0;


    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player3ScoreText;
    public TextMeshProUGUI player2ScoreText;

    public int scoreToReach;


    public void Player1Goal()
    {
        player1Score++;
        player1ScoreText.text = player1Score.ToString();
        CheckScore();
    }

    public void Player2Goal()
    {
        player2Score++;
        player2ScoreText.text = player2Score.ToString();
        CheckScore();
    }
    public void Player3Goal()
    {
        player3Score++;
        player3ScoreText.text = player3Score.ToString();
        CheckScore();
    }
    private void CheckScore()
    {
        if (player1Score == scoreToReach || player2Score == scoreToReach || player3Score == scoreToReach)
        {
            SceneManager.LoadScene(2);
        }
    }
}
