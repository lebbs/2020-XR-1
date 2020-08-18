using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionsLeapmotion : MonoBehaviour
{

    public float rotateSpeed = 90f;
    // Start is called before the first frame update

    public void Rotate()
    {
        transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
