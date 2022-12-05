using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILives : MonoBehaviour
{
    [Header("Live System")]
    [SerializeField] private float liveImageWidth = 12.5f;

    private RectTransform rect;

    private void Awake()
    {
        rect = transform as RectTransform;
    }

    private void Start()
    {
        PlayerManager.Instance.OnLivesChange.AddListener(UpdateLive);
        UpdateLive();
    }

    void UpdateLive()
    {
        Debug.Log(PlayerManager.Instance.GetPlayerLives());
        rect.sizeDelta = new Vector2(liveImageWidth * PlayerManager.Instance.GetPlayerLives(), rect.sizeDelta.y);
    }
}
