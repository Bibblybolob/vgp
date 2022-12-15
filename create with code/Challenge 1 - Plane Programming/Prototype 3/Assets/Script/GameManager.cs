using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver):
        {
        score += 1;
        UpdateScore(0);
        }   
    }
    public void UpdateScore(int scoreToAdd)
    {
        scoreText.text = "Score: " + score;
    }
}
