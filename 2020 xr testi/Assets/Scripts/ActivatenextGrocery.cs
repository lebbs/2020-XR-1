using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatenextGrocery : MonoBehaviour
{
    public GameObject arrow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Controller")||
            other.gameObject.CompareTag("Shoppingcart"))
        {
            arrow.SetActive(false);
        }

        
    }
    private void OnTriggerExit(Collider other)
    {
        arrow.SetActive(true);
    }
}
