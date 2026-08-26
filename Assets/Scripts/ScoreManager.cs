using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int score;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        score = 0;
        scoreText.text = "SCORE: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int addedScore)
    {
        score+=addedScore;
        scoreText.text = "SCORE: " + score;
    }

    public void deductScore(int deductedScore)
    {
        score -= deductedScore;
        scoreText.text = "SCORE: " + score;

        if (score < -20)
        {
            scoreText.text = "YOU LOSE!!";
        }
    }

    public int getScore()
    {
        return score;
    }

}
