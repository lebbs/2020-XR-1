using Leap;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;
    public GameObject target1;
    public Material material1;
    public Material material2;
    public Material material3;

    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {


        //switch (collision.transform.tag)
        //{
        //    case "Pickable":
        //        theScore += 1;
        //        scoreText.GetComponent<TextMesh>().text = "Score: " + theScore + "/" + "8";
        //        break;      
        //}

        if (collision.gameObject.tag == "Pickable")
        {
            theScore += 1;
            scoreText.GetComponent<TextMesh>().text = "Score: " + theScore + "/" + "3";


            switch (theScore)
            {
                case 0:
                    target1.GetComponent<MeshRenderer>().material = material3;
                    break;

                case 1:
                    target1.GetComponent<MeshRenderer>().material = material1;
                    break;

                case 2:
                    target1.GetComponent<MeshRenderer>().material = material2;
                    break;

                case 3:
                    theScore = 0;
                    target1.SetActive(false);
                    scoreText.SetActive(false);
                    break;
            }
        }
    }
}
