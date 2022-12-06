using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void ChangeValue(Slider slider)
    {
        switch (slider.value)
        {
            case 0:
                audioMixer.SetFloat("Effects", -80f);
                break;
            case 1:
                audioMixer.SetFloat("Effects", -25f);
                break;
            case 2:
                audioMixer.SetFloat("Effects", -15f);
                break;
            case 3:
                audioMixer.SetFloat("Effects", -5f);
                break;
            case 4:
                audioMixer.SetFloat("Effects", 0f);
                break;
            case 5:
                audioMixer.SetFloat("Effects", 20f);
                break;
            default:
                break;
        }
    }
}
