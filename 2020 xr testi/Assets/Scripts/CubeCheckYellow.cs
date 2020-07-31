using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCheckYellow : MonoBehaviour
{
    public GameObject UiObjectRight;
    public GameObject UiObjectWrong;
    public GameObject Trigger;

    // Start is called before the first frame update
    void Start()
    {
        UiObjectRight.SetActive(false);
        UiObjectWrong.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ShowAndHide(UiObjectRight, 1.0f));
        {
            if (other.tag == "YellowCube")
            {
                UiObjectRight.SetActive(true);
            }
            else
            {
                UiObjectRight.SetActive(false);
                // UiObjectRight.SetActive(true);
            }
        }
    }
    IEnumerator ShowAndHide(GameObject gameObject, float delay)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        UiObjectRight.SetActive(false);
        UiObjectWrong.SetActive(false);
    }



}