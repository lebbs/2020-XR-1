using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    public GameObject snapLocation;

    public GameObject obj;

    public bool isSnapped;

    private bool objectSnapped;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectSnapped = snapLocation.GetComponent<SnapToPosition>().snapped;

        if(objectSnapped == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.SetParent(obj.transform);
            isSnapped = true;
        }
    }
}
