using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGameEvents : MonoBehaviour
{

    public GameObject Targets;
    public GameObject Throwables;
    // Start is called before the first frame update
    public void OnCustomButtonPress()
    {
        if(Targets.activeSelf == false || Throwables.activeSelf == false)
        {
            Targets.SetActive(true);
            Throwables.SetActive(true);
        }
        else
        {
            Targets.SetActive(false);
            Throwables.SetActive(false);
        }
    }

    
}
