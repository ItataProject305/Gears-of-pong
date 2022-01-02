using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Balong")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject textScore1;
    public GameObject textScore2;

    private int score1;
    private int score2;

    public void player1Scored() {
        score1++;
        textScore1.GetComponent<TextMeshProUGUI>().text = score1.ToString();
        ResetPosition();
    }

    public void player2Scored()
    {
        score2++;
        textScore2.GetComponent<TextMeshProUGUI>().text = score2.ToString();
        ResetPosition();
    }

    void ResetPosition() {
        ball.GetComponent<Balong>().Reset();
        player1Paddle.GetComponent<Player>().Reset();
        player2Paddle.GetComponent<Player>().Reset();
    }
}
