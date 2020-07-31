using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Ohjain")
        {
            SceneManager.LoadScene("Pallopeli");
        }
    }
    // Start is called before the first frame update
    public void LoadScenePallopeli()
    {
        SceneManager.LoadScene("Pallopeli");
    }

    public void LoadScenePingispeli()
    {
        SceneManager.LoadScene("Pingispeli");
    }
}
