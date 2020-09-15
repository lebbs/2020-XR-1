using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSystem : MonoBehaviour
{
    public GameObjScript[] gameObjArray;

    public GameObject[] targets;
    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Target");
        

        PopulateGameObjArray();
       
    }

    void PopulateGameObjArray()
    {
        gameObjArray = GetComponentsInChildren<GameObjScript>();

    }

    public void CheckObjStatus()
    {
        if (AreAllGameObjInactive())
        {
            foreach (GameObject gameObject in targets)
            {
                Wait();
                gameObject.SetActive(true);
            }

            print("kaikki on epäaktiivisia");           
        }
        else
        {
            print("yksi on aktiivinen");
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
    }

    bool AreAllGameObjInactive()
    {
        foreach(GameObjScript gameObj in gameObjArray)
        {
            if (gameObj.gameObject.activeInHierarchy)
            {
                return false;
            }
        }
        return true;
    }
}
