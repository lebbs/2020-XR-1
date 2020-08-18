using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using Varjo.XR;
using VarjoExample;

public class MenuInteraction : MonoBehaviour
{
    //public Transform xrRig;
    public GameObject Menu;
    public GameObject VivePointers;
    Controller controller;
    private bool triggerDown;
    int i = 0;
    void Start()
    {
        controller = GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.primary2DAxisClick)
        {
            if (!triggerDown && !Menu.activeSelf)
            {
                VivePointers.SetActive(true);
                Menu.SetActive(true);
                Debug.Log("Menu auki");
            }
         
        }

        if(controller.primary2DAxisClick && Menu.activeSelf)
        {
            VivePointers.SetActive(false);
            Menu.SetActive(false);
        }
    }
}
