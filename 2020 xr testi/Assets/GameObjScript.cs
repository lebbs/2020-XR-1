using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjScript : MonoBehaviour
{
    spawnSystem parentScript;

    private void Awake()
    {
        parentScript = transform.GetComponentInParent<spawnSystem>();
    }

    private void OnDisable()
    {
        parentScript.CheckObjStatus();
    }
}
