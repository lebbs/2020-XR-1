using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{

    public float m_DefaultLength = 5.0f;
    public GameObject dot;
    public VRInputModule InputModule;

    private LineRenderer lineRenderer = null;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

   

    // Update is called once per frame
    void Update()
    {
        UpdateLine();
    }

    private void UpdateLine()
    {
        float targetLenght = m_DefaultLength;

        RaycastHit hit = CreateRaycast(targetLenght);

        Vector3 endPosition = transform.position + (transform.forward * targetLenght);

        if(hit.collider != null)
        {
            endPosition = hit.point;
        }
        dot.transform.position = endPosition;

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, endPosition);
    }
    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        Physics.Raycast(ray, out hit, m_DefaultLength);

        return hit;
    }
}
