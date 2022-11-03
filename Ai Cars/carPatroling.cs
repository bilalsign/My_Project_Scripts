using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class carPatroling : MonoBehaviour
{
 //   bool yourVar =false;
    public Transform[] waypoints;
    public int speed;
    private int waypointsIndex;
    private float distance;


  //Raycast Range-------------
   public float range = 5f;
  //---------------------------

    void Start()
    {
        waypointsIndex = 0;
        transform.LookAt(waypoints[waypointsIndex].position);

    }
    void Update()
    {
        distance = Vector3.Distance(transform.position, waypoints[waypointsIndex].position);
        if (distance <1f  )
        {
            IncreaseIndex();
        }
        Patrol();


       

        //----------------------------------------Raycast---------------------------------------
       
        
       
       /* Vector3 direction = Vector3.forward;
        Vector3 rdirection = Vector3.right;
        Vector3 ldirection = Vector3.left;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Ray theRayr = new Ray(transform.position, transform.TransformDirection(rdirection * range));
        Ray theRayl = new Ray(transform.position, transform.TransformDirection(ldirection * range));


        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(rdirection * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(ldirection * range));

        if (Physics.Raycast(theRay, out RaycastHit hit,range))
        {
            if (hit.collider.tag == "Enemy" )
            {

                speed = 0;
            }
            
       
        
        }
       else if (Physics.Raycast(theRayl, out RaycastHit hitt, range))
        {
            if (hitt.collider.tag == "Enemy")
            {

                speed = 0;
            }



        }

       else if (Physics.Raycast(theRayr, out RaycastHit hittt, range))
        {
            if (hittt.collider.tag == "Enemy")
            {

                speed = 0;
            }



        }


*/
        //----------------------------------------EndRayCast-------------------------------------



    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }
    void IncreaseIndex()
    {
        waypointsIndex++;
        if (waypointsIndex >= waypoints.Length)
        {
            waypointsIndex = 0;

        }
        transform.LookAt(waypoints[waypointsIndex].position);
    }

   /* void OnTriggerEnter(Collider other )
    {
      
        if (other.gameObject.tag=="Enemy")
        {
            speed = 0;
        }
       
    }
    void OnTriggerExit(Collider other)
    {
       
        if (other.gameObject.tag !="Enemy")
        {
            speed = 12;
        }
    }*/

    /*void turn()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        speed = 12;


    }*/



    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "other")
        {
            yourVar = false;
            
        }
        else
        {
            yourVar = true;
        }

    }*/



}

















   /* // void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdatDestination();
}

// Update is called once per frame
void Update()
{
    if (Vector3.Distance(transform.position, target) < 1)
    {
        IterateWayPointIndex();
        UpdatDestination();
    }

}
void UpdatDestination()
{
    target = waypoints[waypointIndex].position;
    agent.SetDestination(target);
}
void IterateWayPointIndex()
{
    waypointIndex++;
    if (waypointIndex == waypoints.Length)
    {
        waypointIndex = 0;
    }
}    
}
*/




