using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTiles : MonoBehaviour
{
    GroundSpwaner groundSpwaner;
    // Start is called before the first frame update
   private  void Start()
    {
       groundSpwaner = GameObject.FindObjectOfType<GroundSpwaner>();
    }


    private void OnTriggerExit (Collider other)
    {
        groundSpwaner.SpwanGround();
        Destroy(gameObject,2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
