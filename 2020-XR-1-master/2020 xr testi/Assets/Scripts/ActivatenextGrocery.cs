using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatenextGrocery : MonoBehaviour
{
    public GameObject arrow;
    public Transform parent;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Controller")||
            other.gameObject.CompareTag("Shoppingcart"))
        {
            arrow.SetActive(false);
        }


        if (other.gameObject.CompareTag("Shoppingcart"))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;
            gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.transform.SetParent(parent);

        }

        if (other.gameObject.CompareTag("Controller"))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<BoxCollider>().enabled = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        arrow.SetActive(true);
    }
}
