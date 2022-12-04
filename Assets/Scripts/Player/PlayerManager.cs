using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }

    [SerializeField] private int lives;
    [SerializeField] private Vector3 inicialPosition;

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

    private void Start()
    {
        lives = 2;
        inicialPosition = new Vector3(0, 0, 0);
    }

    public int GetPlayerLives()
    {
        return lives;
    }

    private void ResetPlayer()
    {
        this.gameObject.transform.position = inicialPosition;
        //Start Cooldown to Respawn
        this.gameObject.SetActive(true);
        //Active Invunerability (blink effect)
    }

    void PlayerDeath()
    {
        this.gameObject.SetActive(false);
        //Instantiate Particles
        lives -= 1;

        if(lives <= 0)
        {
            GameManager.Instance.GameOver();
        }
        else
        {
            ResetPlayer();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Asteroid"))
        {            
            PlayerDeath();
        }
    }
}
