using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverHighScore : MonoBehaviour
{
    private TextMeshProUGUI highScore;

    private void Awake()
    {
        highScore = this.GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
}
