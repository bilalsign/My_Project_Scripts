using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespwan : MonoBehaviour
{
    public GameObject [] obstaclePrefabs;
    public float spwanTime = -2;
    private float timer = 0;

    public float speed = 5f;
    void Update()

    {
        if(timer > spwanTime)
        {
            int rand = Random.Range(0,obstaclePrefabs.Length);

            GameObject obs = Instantiate(obstaclePrefabs[rand]);
            obs.transform.position = transform.position + new Vector3(0,0,0);

            Destroy(obs, 4);
            timer = 0;
        }
        timer += Time.deltaTime;
        transform.position += Vector3.back  * speed * Time.deltaTime; 
    }
}
