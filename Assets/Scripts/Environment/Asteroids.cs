using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    [Header("Asteroid Control")]
    [SerializeField] float maxSpeed;
    [SerializeField] float maxTorque;

    [Header("Fragmentation Instances Settings")]
    [SerializeField] private GameObject asteroidPrefab;
    [SerializeField] private int maxAsteroidsInstances = 4;

    [Header("Score Settings")]
    [SerializeField] private int asteroidsPoints;

    [Header("Audio Settings")]
    [SerializeField] private AudioClip destructionSound;


    private Rigidbody2D rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        Vector2 propulsion = new Vector2(Random.Range(-maxSpeed,maxSpeed), Random.Range(-maxSpeed, maxSpeed));
        float torque = Random.Range(-maxTorque, maxTorque);

        rb.AddForce(propulsion);
        rb.AddTorque(torque);

        LevelManager.Instance.IncreaseAsteroidCounter();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {       
        if(!collision.transform.CompareTag("Asteroid"))
        {
            if (asteroidPrefab)
            {
                for (int i = 0; i < Random.Range(2, maxAsteroidsInstances); i++)
                {
                    Instantiate(asteroidPrefab, transform.position, transform.rotation);
                }
            }            

            SoundBox.Instance.PlaySound(destructionSound);

            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        ScoreManager.Instance.IncreaseScore(asteroidsPoints);
        LevelManager.Instance.DecreaseAsteroidCounter();
    }
}
