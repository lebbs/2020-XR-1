using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActivateNextTrigger : MonoBehaviour
{
    public GameObject rightTrigger;
    public GameObject leftTrigger;
    public GameObject centerTrigger;
    Rigidbody rigidbody;


    Vector3 originalPosition;

    private void Start()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.angularVelocity = new Vector3(0, 0, 0);
        rigidbody.velocity = new Vector3(0, 0, 0);
    }

    // Start is called before the first frame update
    private IEnumerator OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("RedCube"))

           yield return new WaitForSeconds(3);
        {
            
                rightTrigger.SetActive(false);
                leftTrigger.SetActive(true);
            }


        if (other.gameObject.CompareTag("RedCube") && leftTrigger.activeSelf)
            yield return new WaitForSeconds(3);
            {
                leftTrigger.SetActive(false);
                centerTrigger.SetActive(true);
            }

        if(other.gameObject.CompareTag("RedCube") && centerTrigger.activeSelf)
            yield return new WaitForSeconds(3);
        {
            centerTrigger.SetActive(false);
            gameObject.transform.position = originalPosition;
            rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.angularVelocity = new Vector3(0, 0, 0);
            rigidbody.velocity = new Vector3(0, 0, 0);
        }
    }

}
