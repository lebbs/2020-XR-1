using Leap;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    private GameObject[] gameObject;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {

        switch (collision.transform.tag)
        {
            case "Target1":
                theScore += 1;
                scoreText.GetComponent<TextMesh>().text = "Score: " + theScore + "/" + "8";
                break;

            case "Target2":
                theScore += 1;
                scoreText.GetComponent<TextMesh>().text = "Score: " + theScore + "/" + "8";
                break;
        }

        //if(collision.gameObject.tag == "Pickable")
        //{
        //    theScore += 1;
        //    scoreText.GetComponent<TextMesh>().text = "Score: " + theScore + "/" + "8";
        //    //Destroy(collision.gameObject);
        //    //collision.gameObject.SetActive(false);

        //    if(theScore == 8)
        //    {             
        //       // gameObject.SetActive(true);
        //        theScore = 0;
        //    }
        //}
    }

    //private IEnumerator SpawnTargets()
    //{
    //    yield return new WaitForSeconds(2.0f);
    //    if (GameObject.FindGameObjectWithTag("Target"))
    //    {
    //        gameObject.SetActive(true);
    //    }
    //}
}
