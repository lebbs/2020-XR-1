using Leap;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            theScore += 1;
            scoreText.GetComponent<TextMesh>().text = "Score: " + theScore + "/" + "8";
            Destroy(collision.gameObject);

            if(theScore == 8)
            {
                theScore = 0;
            }
        }
    }
}
