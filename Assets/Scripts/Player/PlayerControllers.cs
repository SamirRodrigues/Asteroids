using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllers : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInputActions playerInputActions;

    [Header("Moviment")]
    [SerializeField] private float torqueValue = 10f;
    [SerializeField] private float propulsionValue = 10f;

    [Header("Enviroment")]
    [SerializeField] private GameObject propulsionEffect;
    [SerializeField] private AudioSource propulsionAudio;

    [Header("Shoot")]
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletForce = 30f;
    [SerializeField] private float bulletDurationTime = 2f;
    [SerializeField] private float cooldown = 0.5f;
    private float currentTime;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        propulsionAudio = this.GetComponent<AudioSource>();
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    private void FixedUpdate()
    {
        LeftRotation();
        RightRotation();
        Propulsion();
        HyperSpace();
        Shoot();
    }



    public void LeftRotation()
    {
        if(playerInputActions.Player.LeftRotation.ReadValue<float>() != 0)
        {
            rb.AddTorque(torqueValue * Time.deltaTime );
        }
    }

    public void RightRotation()
    {
        if (playerInputActions.Player.RightRotation.ReadValue<float>() != 0)
        {
            rb.AddTorque( -torqueValue * Time.deltaTime );
        }
    }

    public void Propulsion()
    {        
        if (playerInputActions.Player.Propulsion.ReadValue<float>() != 0)
        {
            rb.AddRelativeForce(propulsionValue * Vector2.up * Time.deltaTime, ForceMode2D.Impulse );
            propulsionEffect.gameObject.SetActive( true );
            propulsionEffect.GetComponent<PropulsionEffect>().StartAnimation();
            propulsionAudio.GetComponent<AudioSource>().Play();
        }
        else
        {
            propulsionAudio.GetComponent<AudioSource>().Stop();
            propulsionEffect.gameObject.SetActive( false );
        }
    }

    public void HyperSpace()
    {
        if (playerInputActions.Player.HyperSpace.ReadValue<float>() != 0)
        {
            Debug.Log("HyperSpace - NOT IMPLEMENTED YET");
             
        }
    }

    public void Shoot()
    {
        if (playerInputActions.Player.Shoot.ReadValue<float>() != 0)
        {
            if(Time.time >= currentTime + cooldown)
            {
                currentTime = Time.time;
                GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * bulletForce * Time.fixedDeltaTime * 1000f);
                Destroy(newBullet, bulletDurationTime);
            }
        }
    }
}
