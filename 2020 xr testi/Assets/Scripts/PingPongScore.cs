using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PingPongScore : MonoBehaviour
{

    public GameObject scoreText;
    public int score;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PingPongBall")
        {
            score += 1;
            scoreText.GetComponent<TextMesh>().text = "Score: " + score;
            Destroy(GameObject.FindWithTag("PingPongBall"));
        }
    }
}
