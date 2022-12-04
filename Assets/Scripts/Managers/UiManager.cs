using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private TextMeshProUGUI scoreText;

    void Start()
    {
        PlayerManager.Instance.OnLivesChange.AddListener(UpdateLive);
        GameManager.Instance.OnScoreChange.AddListener(UpdateScore);
        livesText.text = "Lives x" + PlayerManager.Instance.GetPlayerLives().ToString();
        scoreText.text = "Score x" + GameManager.Instance.GetScore().ToString();
    }

    void UpdateLive()
    {        
        livesText.text = "Lives x" + PlayerManager.Instance.GetPlayerLives().ToString();         
    }

    void UpdateScore()
    {
        scoreText.text = "Score x" + GameManager.Instance.GetScore().ToString();
    }
}
