using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNext : MonoBehaviour
{
    public GameObject energyDrinkTrigger;
    public GameObject juicePackTrigger;
    public GameObject cerealBoxTrigger;
    public GameObject chipsTrigger;

    private int luku;

    private void Start()
    {
        energyDrinkTrigger.SetActive(false);
        juicePackTrigger.SetActive(false);
        cerealBoxTrigger.SetActive(false);
        chipsTrigger.SetActive(false);


        //cerealBoxTrigger.GetComponent<MeshRenderer>().enabled = false;
        //energyDrinkTrigger.GetComponent<MeshRenderer>().enabled = false;
        //juicePackTrigger.GetComponent<MeshRenderer>().enabled = false;
        //chipsTrigger.GetComponent<MeshRenderer>().enabled = false;

        luku = Random.Range(1,4);
        Debug.Log("Numero arvottu" + luku);

        switch (luku)
        {
            case 1:
                cerealBoxTrigger.SetActive(true);
                //cerealBoxTrigger.GetComponent<MeshRenderer>().enabled = true;

                break;
            case 2:
                //juicePackTrigger.GetComponent<MeshRenderer>().enabled = true;
                juicePackTrigger.SetActive(true);
                break;
            case 3:
                //energyDrinkTrigger.GetComponent<MeshRenderer>().enabled = true;
                energyDrinkTrigger.SetActive(true);
                break;
            case 4:
                //chipsTrigger.GetComponent<MeshRenderer>().enabled = true;
                chipsTrigger.SetActive(true);
                break;

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cereal"))
        {
            //cerealBoxTrigger.SetActive(false);
            juicePackTrigger.SetActive(true);
            //cerealBoxTrigger.GetComponent<MeshRenderer>().enabled = false;
            //cerealBoxTrigger.GetComponent<SnapOnTarget>().enabled = false;

            //juicePackTrigger.GetComponent<MeshRenderer>().enabled = true;
        }

        if (other.gameObject.CompareTag("Juicepack"))
        {
            //juicePackTrigger.SetActive(false);
            energyDrinkTrigger.SetActive(true);

            //juicePackTrigger.GetComponent<MeshRenderer>().enabled = false;
            //energyDrinkTrigger.GetComponent<MeshRenderer>().enabled = true;
        }

        if (other.gameObject.CompareTag("Energydrink"))
        {
            //energyDrinkTrigger.SetActive(false);
            chipsTrigger.SetActive(true);

            //energyDrinkTrigger.GetComponent<MeshRenderer>().enabled = false;
            //chipsTrigger.GetComponent<MeshCollider>().enabled = true;
        }

        if (other.gameObject.CompareTag("Chips"))
        {
            //chipsTrigger.SetActive(false);
            cerealBoxTrigger.SetActive(true);
            //chipsTrigger.GetComponent<MeshRenderer>().enabled = false;
            //cerealBoxTrigger.GetComponent<MeshRenderer>().enabled = true;
           // cerealBoxTrigger.SetActive(true);
        }
    }

}
