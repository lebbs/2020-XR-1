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
           if ( theScore == 1)
            {
                target1.GetComponent<MeshRenderer>().material = material1;

            }
           if (theScore == 2)
            {
                target1.GetComponent<MeshRenderer>().material = material2;
            }
            //Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);
            if (theScore == 3)
            {
                 target1.SetActive(false);
                theScore = 0;
            }
        }
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
