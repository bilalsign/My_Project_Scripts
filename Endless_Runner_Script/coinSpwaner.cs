using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpwaner : MonoBehaviour
{
    public GameObject [] obstaclePrefabs;
       public float spwanTime = -2;
    private float timer = 0;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        SpwanCoins();
    }

    // Update is called once per frame
    void SpwanCoins ()
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
