using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoreManager;
    [SerializeField] private Text scoreText;
    private int score;

    void Start()
    {
        scoreManager = this;
    }

    public void IncreaseScore(int increase)
    {
        score += increase;
        scoreText.text = ((int)score).ToString();
    }
}
