using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooterSystem : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletForce;

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameObject newBullet = Instantiate(bullet,transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * bulletForce * Time.fixedDeltaTime * 1000f);
            Destroy(newBullet, 3.5f);
        }
    }
}
