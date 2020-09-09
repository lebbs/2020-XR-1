using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ostoslista : MonoBehaviour
{
    //OSTOSLISTA
    public GameObject energyDrink;
    public GameObject juicePack;
    public GameObject chips;
    public GameObject groceryCereal;
    //AJASTIN
    public float timeStart;
    public TextMeshPro textBox;
    bool timerActive = false;

    //PISTEET
    public int theScore1;
    public int theScore2;
    public int theScore3;
    public int theScore4;

    private int i = 0;
    // public Material material;
    // public GameObject checkmark;

    private void Start()
    {
        textBox.text = timeStart.ToString("F2");
        timerActive = true;
    }

    //private void Timer()
    //{
    //    timeStart += Time.deltaTime;
    //    textBox.text = timeStart.ToString("F2");
    //}
    

    

    private void Update()
    {
        if (timerActive)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.CompareTag("Cereal"))
        {
            theScore1 += 1;
            groceryCereal.GetComponentInChildren<TextMeshPro>().text = theScore1 + "/2";

            Debug.Log("Muro trigger w�rkkii");
            if(theScore1 == 2)
            {
                groceryCereal.GetComponentInChildren<SpriteRenderer>().material.color = Color.green;
            } 
        }

        if (other.gameObject.CompareTag("Chips"))
        {
            theScore4 += 1;
            chips.GetComponentInChildren<TextMeshPro>().text = theScore4 + "/2";

            if (theScore4 == 2)
            {
                chips.GetComponentInChildren<SpriteRenderer>().material.color = Color.green;
            }

            
            
        }

        if (other.gameObject.CompareTag("Energydrink"))
        {
           

            theScore3 += 1;
            energyDrink.GetComponentInChildren<TextMeshPro>().text = theScore3 + "/2";

            if(theScore3 == 2)
            {
                energyDrink.GetComponentInChildren<SpriteRenderer>().material.color = Color.green;
            }
        }

        if (other.gameObject.CompareTag("Juicepack"))
        {
            theScore2 += 1;
            juicePack.GetComponentInChildren<TextMeshPro>().text = theScore2 + "/2";

            if(theScore2 == 2)
            {
                juicePack.GetComponentInChildren<SpriteRenderer>().material.color = Color.green;
            }
        }

        //Debug.Log(i)
    }

    private void OnTriggerExit(Collider other)
    {
        if(theScore1 > 0)
        //CEREAL
        theScore1 -= 1;
        groceryCereal.GetComponentInChildren<TextMeshPro>().text = theScore1 + "/2";

        if (theScore2 > 0)
            //JUICE
            theScore2 -= 1;
        juicePack.GetComponentInChildren<TextMeshPro>().text = theScore2 + "/2";

        if (theScore3 > 0)
            //ENERGYDRINK
            theScore3 -= 1;
        energyDrink.GetComponentInChildren<TextMeshPro>().text = theScore3 + "/2";

        if (theScore4 > 0)
            //CHIPS
            theScore4 -= 1;
        chips.GetComponentInChildren<TextMeshPro>().text = theScore4 + "/2";

    }

}