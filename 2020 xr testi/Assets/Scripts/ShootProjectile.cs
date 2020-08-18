using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float projectileForce;

    public float maxTime = 5;
    public float minTime = 2;

    private float time;
    private float spawnTime;

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
        
    }

    void SpawnObject()
    {
        
            time = 0;
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * projectileForce);
        //time = 0;
        //GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
        //shot.GetComponent<Rigidbody>().AddForce(transform.forward * projectileForce);
    }

    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }
}
