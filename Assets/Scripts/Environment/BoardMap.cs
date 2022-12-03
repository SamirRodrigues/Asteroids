using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoardMap : MonoBehaviour
{
    [SerializeField]
    private float topBoard;
    [SerializeField]
    private float downBoard;
    [SerializeField]
    private float leftBoard;
    [SerializeField]
    private float rightBoard;

    private void OnTriggerExit2D(Collider2D collision)
    {

        Vector2 newPos = collision.GetComponent<Transform>().position;

        if(newPos.y > topBoard)
        {
            newPos.y = downBoard;
            collision.GetComponent<Transform>().position = newPos;
        }
        
        if(newPos.y < downBoard)
        {
            newPos.y = topBoard;
            collision.GetComponent<Transform>().position = newPos;
        }

        if (newPos.x > rightBoard)
        {
            newPos.x = leftBoard;
            collision.GetComponent<Transform>().position = newPos;
        }
        
        if (newPos.x < leftBoard)
        {
            newPos.x = rightBoard;
            collision.GetComponent<Transform>().position = newPos;
        }

    }
}
