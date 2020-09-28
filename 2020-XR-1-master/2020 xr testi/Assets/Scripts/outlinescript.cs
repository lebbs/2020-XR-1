using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlinescript : MonoBehaviour
{

    [SerializeField] private Material outlineMaterial;
    [SerializeField] public float outlineScaleFactor;
    [SerializeField] private Color outlineColor;
    private Renderer outlineRenderer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Controller"))
        {
            outlineRenderer.enabled = true;          
        }
    }

    private void OnTriggerExit(Collider other)
    {
        outlineRenderer.enabled = false;
    }

    void Start()
    {
        outlineRenderer = CreateOutline(outlineMaterial, outlineScaleFactor, outlineColor);

        outlineRenderer.enabled = false;
    }

    Renderer CreateOutline(Material outlineMat, float scaleFactor, Color color)
    {

        GameObject outlineObject = Instantiate(this.gameObject, transform.position, transform.rotation, transform);
        Renderer rend = outlineObject.GetComponent<Renderer>();
        Rigidbody rigidbody = outlineObject.GetComponent<Rigidbody>();
        rigidbody.isKinematic = true;
        rend.material = outlineMat;
        rend.material.SetColor("_OutlineColor", color);
        rend.material.SetFloat("_ScaleFactor", scaleFactor);
        rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        outlineObject.transform.GetChild(0).gameObject.SetActive(false);
        outlineObject.GetComponent<outlinescript>().enabled = false;
        outlineObject.GetComponent<Collider>().enabled = false;
        rend.enabled = false;
        return rend;
    }
}