using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<ActivatenextGrocery>().enabled = false;
      
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Controller"))
    //    {
    //        gameObject.GetComponent<ActivatenextGrocery>().enabled = true;
    //    }
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    gameObject.GetComponent<ActivatenextGrocery>().enabled = false;
    //}

}
