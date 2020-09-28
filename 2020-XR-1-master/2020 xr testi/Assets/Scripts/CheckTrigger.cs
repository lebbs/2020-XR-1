using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "puhelinlaatikko")
        {
            Debug.Log("Trigger toimii");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "puhelinlaatikko" ||
            collision.gameObject.tag == "Pickable")
        {
            Debug.Log("collision toimii");
        }
    }
}
