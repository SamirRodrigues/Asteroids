using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PropulsionEffect : MonoBehaviour
{
    public void StartAnimation()
    {
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        Transform currentPosition = GetComponent<Transform>();

        while(this.gameObject.activeSelf)
        {
            Vector3 position = currentPosition.localPosition;

            if (currentPosition.localPosition.y == -0.1f)
            {
                position.y = -0.2f;
            }
            else
            {
                position.y = -0.1f;
            }

            currentPosition.localPosition = position;

            yield return new WaitForSeconds(0.1f);
        }
        
    }    
}
