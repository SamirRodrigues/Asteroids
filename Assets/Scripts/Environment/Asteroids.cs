using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] float maxTorque;

    [SerializeField] private GameObject asteroidPrefab;
    [SerializeField] private int maxAsteroidsInstances = 4;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector2 propulsion = new Vector2(Random.Range(-maxSpeed,maxSpeed), Random.Range(-maxSpeed, maxSpeed));
        float torque = Random.Range(-maxTorque, maxTorque);

        rb.AddForce(propulsion);
        rb.AddTorque(torque);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {       
        if(collision.transform.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        if(asteroidPrefab)
        {
            for (int i = 0; i < Random.Range(2,maxAsteroidsInstances); i++)
            {
                Instantiate(asteroidPrefab, transform.position, transform.rotation);
            }
        }
    }

}
