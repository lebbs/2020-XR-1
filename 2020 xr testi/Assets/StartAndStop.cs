using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VarjoExample;

public class StartAndStop : MonoBehaviour
{
    
    public GameObject shooter1;
    public GameObject shooter2;
    public GameObject shooter3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PingPongTable"))
        {
            shooter1.GetComponent<ShootProjectile>().enabled = false;
            shooter2.GetComponent<ShootProjectile>().enabled = false;
            shooter3.GetComponent<ShootProjectile>().enabled = false;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PingPongTable"))
        {
            shooter1.GetComponent<ShootProjectile>().enabled = true;
            shooter2.GetComponent<ShootProjectile>().enabled = true;
            shooter3.GetComponent<ShootProjectile>().enabled = true;
        }
    }

}
