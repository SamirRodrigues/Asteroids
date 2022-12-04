using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private TextMeshProUGUI scoreText;

    private int currentLives;
    private int currentScore;


    // Start is called before the first frame update
    void Start()
    {
        currentLives = PlayerManager.Instance.GetPlayerLives();
        currentScore = GameManager.Instance.GetScore();
        livesText.text = "Lives x" + PlayerManager.Instance.GetPlayerLives().ToString();
        scoreText.text = "Score x" + GameManager.Instance.GetScore().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentLives != PlayerManager.Instance.GetPlayerLives())
        {
            livesText.text = "Lives x" + PlayerManager.Instance.GetPlayerLives().ToString();
            currentLives = PlayerManager.Instance.GetPlayerLives();
        }

        if(currentScore != GameManager.Instance.GetScore())
        {
            scoreText.text = "Score x" + GameManager.Instance.GetScore().ToString();
            currentScore = GameManager.Instance.GetScore();
        }
    }
}
