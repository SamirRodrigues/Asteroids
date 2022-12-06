using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerControllers : MonoBehaviour
{
    public static PlayerControllers Instance { get; private set; }

    [HideInInspector] public UnityEvent OnBulletTimeActive;

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
    [SerializeField] private float overHit = 0.5f;
    private float currentHitTime;

    [Header("BulletTime")]
    [Tooltip("The timescale changes to 20%, time in second will be seconds*20/100 (sec/5)")]
    [SerializeField] private float durationTime = 3f;
    [SerializeField] private float bulletTimeCooldown = 10f;
    private float currentTime;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        propulsionAudio = this.GetComponent<AudioSource>();
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void FixedUpdate()
    {
        LeftRotation();
        RightRotation();
        Propulsion();
        BulletTime();
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

    public void BulletTime()
    {
        if (playerInputActions.Player.BulletTime.ReadValue<float>() != 0)
        {
            if(Time.time >= currentTime + bulletTimeCooldown)
            {
                OnBulletTimeActive?.Invoke();
                currentTime = Time.time;
                Time.timeScale = 0.3f;
                StartCoroutine(RestoreTimeScale());
            }
        }
    }

    IEnumerator RestoreTimeScale()
    {
        yield return new WaitForSeconds(durationTime);
        Time.timeScale = 1;
    }

    public void Shoot()
    {
        if (playerInputActions.Player.Shoot.ReadValue<float>() != 0)
        {
            if(Time.time >= currentHitTime + overHit)
            {
                currentHitTime = Time.time;
                GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * bulletForce * Time.fixedDeltaTime * 1000f);
                Destroy(newBullet, bulletDurationTime);
            }
        }
    }
}
