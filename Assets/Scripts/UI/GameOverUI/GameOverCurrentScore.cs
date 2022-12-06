using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverCurrentScore : MonoBehaviour
{
    private TextMeshProUGUI score;

    private void Awake()
    {
        score = this.GetComponent<TextMeshProUGUI>();
    }
    void Start()
    {
        score.text = "Score: " + PlayerPrefs.GetInt("CurrentScore").ToString();
    }
}
