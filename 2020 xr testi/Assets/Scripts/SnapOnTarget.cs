using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnapOnTarget : MonoBehaviour
{
    public Transform attachPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            Debug.Log("trigger toimii");
            transform.position = attachPoint.transform.position;
            gameObject.GetComponent<Transform>().SetParent(attachPoint.transform);
        }

    }
}
