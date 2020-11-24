using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changegravity : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Physics.gravity += new Vector3(0, 1.0f, 0);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Physics.gravity -= new Vector3(0, 1.0f, 0);
        }
        
    }
}
