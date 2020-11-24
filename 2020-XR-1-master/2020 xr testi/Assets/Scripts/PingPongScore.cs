using Leap;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PingPongScore : MonoBehaviour
{

    public GameObject scoreText;
    public GameObject hitText;
    public int score;
    private Renderer renderer;
    public Material color1;
    public Material color2;

    private float time = 2.0f;
    // Start is called before the first frame update

    //private void Start()
    //{
    //    renderer.GetComponent<Renderer>();
    //}

    private void Update()
    {
        time = time + Time.deltaTime;

       
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(ShowAndHide(hitText, 2.0f));
        { 
        if (collision.gameObject.tag == "PingPongBall")
        {
            //renderer.material = color2;
            score += 1;
            scoreText.GetComponent<TextMesh>().text = "Score: " + score;
            GetComponent<MeshRenderer>().material = color2;
            //Destroy(GameObject.FindWithTag("PingPongBall"));
            Destroy(collision.gameObject);

            StartCoroutine(ChangeMaterial());
        }
        }
    }
    IEnumerator ShowAndHide(GameObject gameObject, float delay)
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        gameObject.SetActive(false);
    }

    private IEnumerator ChangeMaterial()
    {
        yield return new WaitForSeconds(2.0f);
        GetComponent<MeshRenderer>().material = color1;
    }
    //private void OnCollisionExit(Collision collision)
    //{
    //    if(collision.gameObject.tag == "PingPongBall")
    //    {
    //        GetComponent<MeshRenderer>().material = color1;
    //    }
    //}


}
