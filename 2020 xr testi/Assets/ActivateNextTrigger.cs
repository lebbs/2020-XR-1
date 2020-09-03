using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActivateNextTrigger : MonoBehaviour
{
    public GameObject rightTrigger;
    public GameObject leftTrigger;
    public GameObject centerTrigger;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("RedCube"))
        {
            StartCoroutine(Timer(rightTrigger, 2.0f));
            {
                rightTrigger.SetActive(false);
                leftTrigger.SetActive(true);
            }

            if (other.gameObject.CompareTag("RedCube") && leftTrigger.activeSelf)
            {
                leftTrigger.SetActive(false);
                centerTrigger.SetActive(true);
            }

        }
    }

    IEnumerator Timer(GameObject gameObject, float delay)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }
}
