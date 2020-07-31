using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using VarjoExample;
using Varjo.XR;
public class VRInputModule : MonoBehaviour
{
    public Camera camera;
    Controller controller;
    // Start is called before the first frame update
    private void Awake()
    {
        controller = GetComponent<Controller>();
    }

    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
