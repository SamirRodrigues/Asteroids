using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BoardMap : MonoBehaviour
{
    public static BoardMap Instance;

    public float topBoard;
    public float downBoard;
    public float leftBoard;
    public float rightBoard;

    private void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);

        Instance = this;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var teleportableObject = collision.GetComponent<CrossBorders>();

        if (teleportableObject != null)
        {
            teleportableObject.CrossLine();
        }
    }
}
