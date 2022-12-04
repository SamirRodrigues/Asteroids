using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

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
    }

    public void IncreaseScore(int value)
    {
        OnScoreChange?.Invoke();
        score += value;
    }

    public int GetScore()
    {
        return score;
    }

    public void GameOver()
    {
        Debug.Log("GameOver");
    }

    
}
