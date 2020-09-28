using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using Varjo.XR;
using VarjoExample;

public class MenuInteraction : MonoBehaviour
{
    //public Camera Camera;

    //Vector3 positionToSave;
    //Quaternion rotationToSave;

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
        if (controller.primaryButton)
        {
            if (!triggerDown && !Menu.activeSelf)
            {
                //        positionToSave = Camera.transform.position + new Vector3(-2, 0, 0);
                //          rotationToSave = Camera.transform.rotation;
                VivePointers.SetActive(true);
                //      Menu.transform.localPosition = positionToSave;
                //    Menu.transform.localRotation = rotationToSave;
                Menu.SetActive(true);
                Debug.Log("Menu auki");
            }
            
            //if(triggerDown && Menu.activeSelf)
            //{
            //    Menu.SetActive(false);
            //}
                


         
        }

        //if(controller.primary2DAxisClick && Menu.activeSelf)
        //{
        //    VivePointers.SetActive(false);
        //    Menu.SetActive(false);
        //}
    }
}
