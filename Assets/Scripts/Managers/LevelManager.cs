using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance { get; private set; }

    private int asteroidCounter;
    private int levelCounter = 1;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public int GetLevel()
    {
        return levelCounter;
    }

    public void IncreaseAsteroidCounter()
    {
        asteroidCounter++;
        Debug.Log(asteroidCounter);
    }

    public void DecreaseAsteroidCounter()
    {
        asteroidCounter--;
        Debug.Log(asteroidCounter);

        if(asteroidCounter <= 0)
        {
            levelCounter++;
            SceneController.Instance.ResetLevel();
        }
    }
}
