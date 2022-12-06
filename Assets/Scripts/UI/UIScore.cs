using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    void Start()
    {
        ScoreManager.Instance.OnScoreChange.AddListener(UpdateScore);
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = ScoreManager.Instance.GetScore().ToString();
    }
}
