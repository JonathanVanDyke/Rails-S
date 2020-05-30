using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] private int scorePerHit = 12;

    private int score;
    private Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();
    }

    public void ScoreHit(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }

    private void AliveBonus(int points)
    {
        score += points;
    }
}
