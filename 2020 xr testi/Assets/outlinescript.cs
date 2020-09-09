using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outlinescript : MonoBehaviour
{

    [SerializeField] private Material outlineMaterial;
    [SerializeField] public float outlineScaleFactor;
    [SerializeField] private Color outlineColor;
    private Renderer outlineRenderer;
    // Start is called before the first frame update


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Controller"))
        {
            //outlineRenderer = CreateOutline(outlineMaterial, outlineScaleFactor, outlineColor);
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
        //outlineObject.GetComponent<Rigidbody>().isKinematic = true;
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

    //private void OnMouseEnter()
    //{
    //    outlineRenderer.enabled = true;
    //}

    //private void OnMouseOver()
    //{
    //    transform.Rotate(Vector3.up, 1f, Space.World);
    //}

    //private void OnMouseExit()
    //{
    //    outlineRenderer.enabled = false;
    //}
}