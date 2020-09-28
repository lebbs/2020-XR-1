using Leap.Unity.Geometry;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererSettings : MonoBehaviour
{

    [SerializeField] LineRenderer rend;
    Vector3[] points;

    public GameObject panel;
    public Image image;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<LineRenderer>();

        points = new Vector3[2];

        points[0] = Vector3.zero;

        points[1] = transform.position + new Vector3(0, 0, 20);

        rend.SetPositions(points);
        rend.enabled = true;

        image = panel.GetComponent<Image>();

    }

    public LayerMask layerMask;

    public bool AlignLineRenderer(LineRenderer rend)
    {
        bool hitButton = false;
        Ray ray;
        ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, layerMask))
        {
            points[1] = transform.forward + new Vector3(0, 0, hit.distance);
            rend.startColor = Color.red;
            rend.endColor = Color.red;
            button = hit.collider.gameObject.GetComponent<Button>();
            hitButton = true;
        }
        else
        {
            points[1] = transform.forward + new Vector3(0, 0, 20);
            rend.startColor = Color.green;
            rend.endColor = Color.green;
            hitButton = false;
        }
        rend.SetPositions(points);
        rend.material.color = rend.startColor;
        return hitButton;
    }

    public void ColorChangeOnClick()
    {
        if(button.name == "red_button")
        {
            image.color = Color.red;
        }
        if(button.name == "blue_button")
        {
            image.color = Color.blue;
        }
        if(button.name == "green_button")
        {
            image.color = Color.green;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(AlignLineRenderer(rend) && Input.GetAxis("Submit") > 0)
        {
            button.onClick.Invoke();
        }

        AlignLineRenderer(rend);
    }
}
