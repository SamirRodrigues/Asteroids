using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] float maxTorque;

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

}
