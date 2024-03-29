using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float lifeTime;
    Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject, 5);
        }
    }
}
