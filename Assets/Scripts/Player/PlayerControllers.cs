using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllers : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerInputActions playerInputActions;

    [SerializeField] private float torqueValue = 10f;
    [SerializeField] private float propulsionValue = 10f;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    private void FixedUpdate()
    {
        LeftRotation();
        RightRotation();
        Propulsion();
        HyperSpace();
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
        }
        
    }

    public void HyperSpace()
    {
        if (playerInputActions.Player.HyperSpace.ReadValue<float>() != 0)
        {
            Debug.Log("HyperSpace - NOT IMPLEMENTED YET");
             
        }
    }    
}
