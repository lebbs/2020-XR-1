using Leap.Unity.Geometry;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VarjoExample;
using System;


public class SnapOnTarget : MonoBehaviour
{
    public Transform attachPoint;
    public MeshRenderer renderer;
    Rigidbody rigidbody;
    public hand script;
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Target"))
        {
            script.Drop();
            rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.angularVelocity = new Vector3(0, 0, 0);
            rigidbody.velocity = new Vector3(0, 0, 0);
            //transform.position = attachPoint.transform.position;
            gameObject.GetComponent<Transform>().SetParent(attachPoint.transform);
            transform.localPosition = Vector3.zero;
            renderer.enabled = false;
            Debug.Log("trigger toimii");
        }
        else
        {
            renderer.enabled = true;
        }
        //else
        //{
        //    gameObject.GetComponent<MeshRenderer>().enabled = true;
        //}

    }
}
