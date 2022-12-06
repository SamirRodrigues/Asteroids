using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI
;

public class UIBulletTimeButton : MonoBehaviour
{
    private void Start()
    {
        PlayerControllers.Instance.OnBulletTimeActive.AddListener(Active);
        StartCoroutine(Activation());
    }

    IEnumerator Activation()
    {
        GetComponent<Image>().enabled = false;
        yield return new WaitForSeconds(10);
        GetComponent<Image>().enabled= true;
    }

    void Active()
    {
        StartCoroutine(Activation());
    }
}
