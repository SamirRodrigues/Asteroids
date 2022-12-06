using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    [HideInInspector] public UnityEvent OnScoreChange;

    private int score;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        score = 0;

        PlayerPrefs.SetInt("CurrentScore", score);        
    }

    public void IncreaseScore(int value)
    {
        OnScoreChange?.Invoke();
        score += value;

        PlayerPrefs.SetInt("CurrentScore", score);

        if(PlayerPrefs.GetInt("HighScore") <= PlayerPrefs.GetInt("CurrentScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    public int GetScore()
    {
        return score;
    }    
}
