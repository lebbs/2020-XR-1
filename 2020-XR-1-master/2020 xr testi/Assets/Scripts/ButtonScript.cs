using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.Events;

public class ButtonScript : MonoBehaviour
{

    [System.Serializable]

    public class ButtonEvent : UnityEvent { }

    public float pressLength;
    public bool pressed;
    public ButtonEvent downEvent;

    Vector3 starPos;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        starPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Mathf.Abs(transform.position.y - starPos.y);
        if(distance >= pressLength)
        {
            transform.position = new Vector3(transform.position.x, starPos.y - pressLength, transform.position.z);
            if (!pressed)
            {
                pressed = true;
                downEvent?.Invoke();
            }
        }
        else
        {
            pressed = false;
        }
        if(transform.position.y > starPos.y)
        {
            transform.position = new Vector3(transform.position.x, starPos.y, transform.position.z);
        }
    }
}
