using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActivateNextTrigger : MonoBehaviour
{
    public GameObject rightTrigger;
    public GameObject leftTrigger;
    public GameObject centerTrigger;
    public GameObject Uitext1;
    public GameObject Uitext2;
    public GameObject Uitext3;
    Rigidbody rigidbody;

    

    Vector3 originalPosition;

   

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("RightTrigger"))
        {

            Uitext1.SetActive(true);
            StartCoroutine(RightTrigger());
           // new WaitForSeconds(3);
            //ActivateRight();
        }

        if (other.gameObject.CompareTag("LeftTrigger"))
        {
            Uitext2.SetActive(true);
            //yield return new WaitForSeconds(2);    
            StartCoroutine(LeftTrigger());
        }

        if (other.gameObject.CompareTag("CenterTrigger"))
        {

            Uitext3.SetActive(true);
            StartCoroutine(CenterTrigger());
            
        }  
        
    }

    

    IEnumerator RightTrigger()
    {
        yield return new WaitForSeconds(2);
        rightTrigger.SetActive(false);
        leftTrigger.SetActive(true);
    }

    IEnumerator LeftTrigger()
    {
        yield return new WaitForSeconds(2);
        leftTrigger.SetActive(false);
        centerTrigger.SetActive(true);
    }

    IEnumerator CenterTrigger()
    {
        yield return new WaitForSeconds(2);
        centerTrigger.SetActive(false);
    }

}
