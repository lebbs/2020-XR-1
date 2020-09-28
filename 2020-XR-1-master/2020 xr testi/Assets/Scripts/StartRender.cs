using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;
public class StartRender : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Varjo.XR.VarjoMixedReality.StartRender();
        Debug.Log("ehkä toimii?");
    }


   
}
