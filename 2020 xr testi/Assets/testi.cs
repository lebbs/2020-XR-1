using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testi : MonoBehaviour
{

    public GameObject menu;
    public void buttontest()
    {
        Debug.Log("Tooimiiiii");
    }

    public void Hidemenu()
    {
        menu.SetActive(false);
    }
}
