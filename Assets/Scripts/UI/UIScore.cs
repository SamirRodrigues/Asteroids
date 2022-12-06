using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    void Start()
    {
        GameManager.Instance.OnScoreChange.AddListener(UpdateScore);
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = GameManager.Instance.GetScore().ToString();
    }
}
