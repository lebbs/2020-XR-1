using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using VarjoExample;

public class buttons : MonoBehaviour
{

    public GameObject shooter;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Controller")
        {
            shooter.SetActive(true);
        }
    }

}
