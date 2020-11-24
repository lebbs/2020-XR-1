using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoppingCart : MonoBehaviour
{


    private void Start()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Controller")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
    }


   
}
