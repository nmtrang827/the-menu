using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    public int tradeScore = 0;
    public TMP_Text scoreText;
    public TMP_Text tradeText;

    public void AddScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }

    public void Trade()
    {
        if (score >= 10)
        {
            score -= 10;
            tradeScore++;
            scoreText.text = "SCORE: " + score;
            tradeText.text = "TRADE SCORE: " + tradeScore;
        }
    }
}