using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }

    [HideInInspector] public UnityEvent OnLivesChange;

    private Vector3 inicialPosition;
    private int lives;
    
    private float invunerabiliteTime = 3f;

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

        Init();
    }

    private void Init()
    {
        lives = 5;
        inicialPosition = new Vector3(0, 0, 0);
    }

    public int GetPlayerLives()
    {
        return lives;
    }

    public float GetInvunerabiliteTime()
    {
        return invunerabiliteTime;
    }

    private void ResetPlayer()
    {
        this.gameObject.transform.position = inicialPosition;
        //TODO: Start Cooldown to Respawn
        this.gameObject.SetActive(true);
        StartCoroutine(Invulnerabilite());
    }

    void PlayerDeath()
    {  
        //TODO: Instantiate Particles
        lives -= 1;
        OnLivesChange?.Invoke();
        this.gameObject.SetActive(false);

        if(lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
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


    IEnumerator Invulnerabilite()
    {
        GetComponent<PolygonCollider2D>().enabled = false;
        GetComponent<Rigidbody2D>().angularDrag = 0;
        yield return new WaitForSeconds(invunerabiliteTime);
        GetComponent<PolygonCollider2D>().enabled = true;
        GetComponent<Rigidbody2D>().angularDrag = 3;
    }
}
