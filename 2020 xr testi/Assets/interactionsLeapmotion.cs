using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionsLeapmotion : MonoBehaviour
{

    public float rotateSpeed = 90f;
    
    public Material color;
    public Material color2;

    // Start is called before the first frame update

    public void Rotate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }
   
    public void ChangeColor()
    {
        GetComponent<MeshRenderer>().material = color;
    }

    public void OriginalColor()
    {
        GetComponent<MeshRenderer>().material = color2;
    }
}
