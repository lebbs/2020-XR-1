using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testi : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Cursor")
        {
            Debug.Log("Cursor toimii");
        }
    }
}
