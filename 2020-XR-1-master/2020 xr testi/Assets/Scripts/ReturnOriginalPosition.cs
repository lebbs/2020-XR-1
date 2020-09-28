using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnOriginalPosition : MonoBehaviour
{
    Vector3 originalPosition;
    Quaternion startRotation;
    Rigidbody rigidbody;

    void Start()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        startRotation = transform.rotation;
        rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.angularVelocity = new Vector3(0, 0, 0);
        rigidbody.velocity = new Vector3(0, 0, 0);
    }

    void Update()
    {

        //PALAUTTAA KAPPALEEN ALKUPERÄISEEN POSITIOON
        if (gameObject.transform.position.y <= -10)
        {
            rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.angularVelocity = new Vector3(0, 0, 0);
            rigidbody.velocity = new Vector3(0, 0, 0);
            gameObject.transform.position = originalPosition;
            gameObject.transform.rotation = startRotation;
        }
    }

    //PALAUTTAA KAPPALEEN ALKUPERÄISEEN PAIKKAAN
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Target" || collision.collider.tag == "Floor")
        {
            rigidbody = gameObject.GetComponent<Rigidbody>();
            rigidbody.angularVelocity = new Vector3(0, 0, 0);
            rigidbody.velocity = new Vector3(0, 0, 0);
            gameObject.transform.position = originalPosition;
            gameObject.transform.rotation = startRotation;
        }
    }
}
