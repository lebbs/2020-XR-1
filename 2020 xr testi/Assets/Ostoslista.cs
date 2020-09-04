using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ostoslista : MonoBehaviour
{

    //public GameObject energyDrink;
    //public GameObject juicePack;
    //public GameObject cerealBox;
    //public GameObject chips;
    // Start is called before the first frame update
    public GameObject groceryCereal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cereal"))
        {
            Debug.Log("Muro trigger wörkkii");
            groceryCereal.SetActive(false);
        }
    }
}
