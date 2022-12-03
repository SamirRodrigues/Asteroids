using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllers : MonoBehaviour
{

    private Rigidbody2D rb;
    [SerializeField]

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    public void LeftRotation(InputAction.CallbackContext context)
    {
        if(context.started)
        {
            rb.AddTorque(5f);
        }
    }

    public void RightRotation(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            rb.AddTorque(-5f);
        }
    }

    public void Propulsion(InputAction.CallbackContext context)
    {        
        if (context.performed)
        {     
            rb.AddRelativeForce(Vector2.up , ForceMode2D.Impulse);
        }
        
    }

    public void HyperSpace(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("HyperSpace");

        }
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Shoot");

        }
    }
}
