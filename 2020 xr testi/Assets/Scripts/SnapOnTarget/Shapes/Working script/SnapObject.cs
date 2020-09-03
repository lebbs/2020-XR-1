using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    public GameObject snapLocation;

    public GameObject obj;

    public bool isSnapped;

    private bool objectSnapped;

    //public GameObject uiText;

    Vector3 originalPosition;
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

        //rigidbody = gameObject.GetComponent<Rigidbody>();
        //rigidbody.angularVelocity = new Vector3(0, 0, 0);
        //rigidbody.velocity = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        objectSnapped = snapLocation.GetComponent<SnapToPosition>().snapped;

        if(objectSnapped == true)
        {

            //GetComponent<Rigidbody>().isKinematic = true;
           // transform.SetParent(obj.transform);
            isSnapped = true;
            
            //gameObject.transform.position = originalPosition;
        }
        if(objectSnapped == false )
        {
            //GetComponent<Rigidbody>().isKinematic = false;
        }
    }

   
}
