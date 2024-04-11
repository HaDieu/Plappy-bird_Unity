using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    public void addScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
