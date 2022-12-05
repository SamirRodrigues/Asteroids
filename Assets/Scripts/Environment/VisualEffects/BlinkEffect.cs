using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkEffect : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }

    private Color beginColor = Color.white;
    private Color finalColor = new Color (255,255,255,0);

    private bool blink = false;
    private float startblinkTime = 0;

    SpriteRenderer sprite;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        PlayerManager.Instance.OnLivesChange.AddListener(PlayBlinkEffect);
    }

    private void Update()
    {
        if(IsBlinkActive() && blink == true)
        {
            sprite.color = Color.Lerp(beginColor, finalColor, Mathf.PingPong(Time.time * 5, 1));
        }
    }

    void PlayBlinkEffect()
    {
        blink = true;
        startblinkTime = Time.time;
    }

    void StopBlinkEffect()
    {
        if(blink == true)
        {
            sprite.color = Color.white;
            blink = false;
        }
    }

    bool IsBlinkActive()
    {
        if(Time.time <= startblinkTime + PlayerManager.Instance.GetInvunerabiliteTime())
        {
            return true;
        }
        else
        {
            StopBlinkEffect();
        }
        
        return false;
    }


}
