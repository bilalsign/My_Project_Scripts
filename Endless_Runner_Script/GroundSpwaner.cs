using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundSpwaner : MonoBehaviour
{
    public GameObject GroundTile;
    Vector3 nextSpwanPoint;


    public void SpwanGround()
    {
        GameObject temp = Instantiate(GroundTile, nextSpwanPoint, Quaternion.identity);
        nextSpwanPoint = temp.transform.GetChild(1).transform.position;
    }

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpwanGround();
        }
    }

   
}
