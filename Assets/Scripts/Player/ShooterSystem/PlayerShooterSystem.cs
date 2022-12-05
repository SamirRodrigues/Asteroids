using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooterSystem : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletForce = 30f;
    [SerializeField] private float bulletDurationTime = 2f;

    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Shoot.performed += Shoot;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            GameObject newBullet = Instantiate(bullet,transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * bulletForce * Time.fixedDeltaTime * 1000f);
            Destroy(newBullet, bulletDurationTime);
        }
    }
}
