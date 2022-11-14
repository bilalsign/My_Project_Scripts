using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public GameObject player;

    public float pos = 1.5f;
    public float _pos =-0.2f;

    void Start()
    {
        // GameObject childGameObject = new GameObject("childGameObject");
        // childGameObject.transform.SetParent(transform);
        //  parentObject = GameObject.Find("Parent");// The name of the parent object
        // childObject = parentObject.transform.GetChild(0).gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable" && pos <= 6)
        {
            other.transform.parent = transform;
            
            other.transform.position =new Vector3(transform.position.x + pos,transform.position.y,transform.position.z);
            pos++;
            
        
            Debug.Log(other.transform.position);

            // ----Used for making the coins child of the player
            // transform.position = new Vector3(2.22000003f,1.28999996f,-0.0489999987f);
            //other.transform.position =  new Vector3(1f,1.14999998f,0f);
        }
        else if (other.gameObject.tag == "Collectable" && pos >= 6f)
        {
             other.transform.parent = transform;
            
            other.transform.position =new Vector3(transform.position.x - _pos,transform.position.y,transform.position.z);
            _pos++;
           
            Debug.Log(other.transform.position);
        }
       
       else if (other.gameObject.tag == "Collectable" && _pos <= -7f)
        {
            other.transform.parent = transform;
            Debug.Log("You win");

            Debug.Log(_pos +"-----------");
            //  other.transform.parent = transform;
            
            // other.transform.position =new Vector3(transform.position.x - _pos,transform.position.y,transform.position.z);
            // _pos++;
        }
        // {
        // GameObject childGameObject = new GameObject("childGameObject");
        // childGameObject.transform.SetParent(transform);
        // Sphere.transform.SetParent(transform);

        //}
    }
}
