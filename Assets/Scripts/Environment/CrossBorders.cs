using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossBorders: MonoBehaviour
{
    public void CrossLine()
    {
        Vector2 newPos = transform.position;

        if (newPos.y > BoardMap.Instance.topBoard)
        {
            newPos.y = BoardMap.Instance.downBoard;
            transform.position = newPos;
        }
        else if (newPos.y < BoardMap.Instance.downBoard)
        {
            newPos.y = BoardMap.Instance.topBoard;
            transform.position = newPos;
        }

        if (newPos.x > BoardMap.Instance.rightBoard)
        {
            newPos.x = BoardMap.Instance.leftBoard;
            transform.position = newPos;
        }
        else if (newPos.x < BoardMap.Instance.leftBoard)
        {
            newPos.x = BoardMap.Instance.rightBoard;
            transform.position = newPos;
        }
    }
}
