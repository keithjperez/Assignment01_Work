using UnityEngine;
using System.Collections.Generic;
using TMPro;
using NUnit.Framework.Constraints;

public class ScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int score;
    private bool failed = false;
    private int misses;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI missesText;
    
    void Start()
    {
        score = 0;
        misses = 0;
        scoreText.text = "Get to 300 score!\nMiss 5 balls, and you lose!";
        missesText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void addScore(int addedScore)
    {
        if (!failed) {
            score+=addedScore;
            scoreText.text = "SCORE: " + score;

            if (score >= 300)
            {
                missesText.text = "YOU WIN! GO FOR A HIGH SCORE!";
            }

        }
    }

    public void deductScore(int deductedScore)
    {
        if (!failed) {
            score -= deductedScore;
            scoreText.text = "SCORE: " + score;
            missesText.text = "MISSES: ";
            misses++;
            for (int i=0;i < misses;i++) // for every miss on the board already
            {
                missesText.text += "X ";
            }
            if (misses >= 5) {failed = true;}
        }
        if (failed)
        {
            missesText.text = "YOU LOSE!";
        }

    }

    public int getScore()
    {
        return score;
    }

}
