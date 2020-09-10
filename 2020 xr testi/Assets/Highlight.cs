using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public Material material;
    Material originalMaterial;

    private void Start()
    {
        originalMaterial = GetComponent<MeshRenderer>().material;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Controller")
        {
            Debug.Log("Higlight trigger toimii");
            // startColor = gameObject.GetComponent<MeshRenderer>();
            GetComponent<MeshRenderer>().material = material;
                        
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<MeshRenderer>().material = originalMaterial;
    }
}
