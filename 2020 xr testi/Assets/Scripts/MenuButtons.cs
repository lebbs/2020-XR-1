using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public GameObject vivePointer;
    public GameObject menu;
    public GameObject sceneMenu;
    public GameObject difficultyMenu;
    public void buttontest()
    {
        Debug.Log("Tooimiiiii");
    }

    //Functio piilottaa menun n‰kyvist‰. K‰ytet‰‰n sulje nappiin


    public void CloseSceneMenu()
    {
        sceneMenu.SetActive(false);
        menu.SetActive(true);
    }
    public void CloseMenu()
    {
        menu.SetActive(false);
    }
    
    public void Hidemenu()
    {
        menu.SetActive(false);
        vivePointer = GameObject.Find("VivePointers");
        vivePointer.SetActive(false);

    }
    //Lataa nykyisen scenen uudestaan 
    public void ReloadScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    //Vaihtaa scenen nimen mukaan
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(name);
    }

    public void BackToMain()
    {
        menu.SetActive(true);
        sceneMenu.SetActive(false);
        difficultyMenu.SetActive(false);

    }

    public void SceneMenu()
    {
        menu.SetActive(false);
        sceneMenu.SetActive(true);
    }

    public void DifficultyMenu()
    {
        menu.SetActive(false);
        sceneMenu.SetActive(false);
        difficultyMenu.SetActive(true);
    }

    //
    public void lataapallopeli()
    {
        SceneManager.LoadScene("Pallopeli");
    }

    public void lataapalikkapeli()
    {
        SceneManager.LoadScene("Palikkapeli");
    }

    public void lataapingispeli()
    {
        SceneManager.LoadScene("Pingispeli");
    }

    public void lataaLeapmotion()
    {
        SceneManager.LoadScene("LeapMotion testi");
    }

    public void lataapaavalikko()
    {
        SceneManager.LoadScene("Main");
    }
}
