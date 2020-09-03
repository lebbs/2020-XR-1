using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActivateNextTrigger : MonoBehaviour
{
    public GameObject rightTrigger;
    public GameObject leftTrigger;
    public GameObject centerTrigger;
    public GameObject Uitext;
    Rigidbody rigidbody;

    

    Vector3 originalPosition;

   

    // Start is called before the first frame update
    private IEnumerator OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("RedCube"))

            Uitext.SetActive(true);
        yield return new WaitForSeconds(3);
        {
                
                rightTrigger.SetActive(false);
                leftTrigger.SetActive(true);
            }


        if (other.gameObject.CompareTag("RedCube") && leftTrigger.activeSelf)
            Uitext.SetActive(true);

        yield return new WaitForSeconds(3);
            {
                leftTrigger.SetActive(false);
                centerTrigger.SetActive(true);
            }

        if(other.gameObject.CompareTag("RedCube") && centerTrigger.activeSelf)
            Uitext.SetActive(true);
        yield return new WaitForSeconds(3);
        {
            centerTrigger.SetActive(false);
            
        }
    }

}
