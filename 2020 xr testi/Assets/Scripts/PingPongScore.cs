using Leap;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PingPongScore : MonoBehaviour
{

    public GameObject scoreText;
    public int score;
    private Renderer renderer;
    public Material color1;
    public Material color2;
    // Start is called before the first frame update

    private void Start()
    {
        renderer.GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PingPongBall")
        {
            renderer.material = color2;
            score += 1;
            scoreText.GetComponent<TextMesh>().text = "Score: " + score;
            //Destroy(GameObject.FindWithTag("PingPongBall"));
            Destroy(collision.gameObject);

        }
        else
        {
            renderer.material = color1;
        }
    }
}
