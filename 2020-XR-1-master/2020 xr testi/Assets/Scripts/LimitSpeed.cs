using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitSpeed : MonoBehaviour
{
    public float maxSpeed = 100f;
   public Rigidbody rigidbody;
    // Start is called before the first frame update
    private void FixedUpdate()
    {

        if(rigidbody.velocity.magnitude > maxSpeed)
        {
            rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
        }
    }
}

