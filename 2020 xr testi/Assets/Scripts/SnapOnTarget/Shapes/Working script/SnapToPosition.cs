using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VarjoExample;

public class SnapToPosition : MonoBehaviour
{
    // Start is called before the first frame update

    private bool insideSnapZone;

    public bool snapped;

    public GameObject grocery;
    public GameObject SnapRotationReference;

    //public hand script;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == grocery.name)
        {
            insideSnapZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == grocery.name)
        {
            insideSnapZone = false;

        }
    }


    void SnapObject()
    {
        if(insideSnapZone == true)
        {
            //script.Drop();

            grocery.gameObject.transform.position = transform.position;
            grocery.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
            snapped = true;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SnapObject();
    }
}
