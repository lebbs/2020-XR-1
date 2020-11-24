using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float projectileForce = 110;

    public float maxTime = 5;
    public float minTime = 2;

    private float time;
    private float spawnTime;

    public GameObject shooterLeft;
    public GameObject shooterLeft2;

    public GameObject shooterRight;
    public GameObject shooterRight2;

    int i = 0;


    //public Vector3 center;
    //public Vector3 size;


    // Start is called before the first frame update

    private void Start()
    {

        SetRandomTime();
        time = minTime;
    }

    // Update is called once per frame
    void Update()
    {
        //projectile = GameObject.FindGameObjectWithTag("PingPongBall");

            time += Time.deltaTime;
            if (time >= spawnTime)
            {
                SpawnObject();
                SetRandomTime();
            }

        
            //LISÄÄ TAI VÄHENNÄ PALLOJEN VAUHTIA
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            projectileForce = projectileForce + 10;
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            projectileForce = projectileForce - 10;
        }
        
    }

    // void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = new Color(1, 0, 0, 0.5f);
    //    Gizmos.DrawCube(center, size);
    //}

    //public void RandomSpawn()
    //{
    //    Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.x / 2, size.x / 2));
    //    Instantiate(shooterLeft, pos, Quaternion.identity);
    //}

    void SpawnObject()
    {
        
            time = 0;
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * projectileForce);
        //time = 0;
        //GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
        //shot.GetComponent<Rigidbody>().AddForce(transform.forward * projectileForce);


        if( i >= 2)
        {
            //RandomSpawn(); 
            shooterLeft.SetActive(true);
            shooterRight.SetActive(false);
        }

        i++;

        if(i >= 4)
        {
            shooterLeft.SetActive(false);
            shooterRight.SetActive(true);
            i = 0;
        }

    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
