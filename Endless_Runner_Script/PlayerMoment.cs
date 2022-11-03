using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEngine.SceneManager;

public class PlayerMoment : MonoBehaviour
{
    public float pos = 0.5f;
    public float _ypos = 0.64f;
    public float _pos =-2f; 

    public GameObject Sphere;
    public GameManager gameManager;
    public static int coinCount;
    public GameObject coinCountDisplay;

    private Animator anim;
    public Rigidbody rb;
    float horizontalInput = 0;
    public float speed = 5;
    private bool turnLeft, turnRight;

    public float horizontalMultiplayer = 2;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
       
    }
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplayer;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

    }


    void OnTriggerEnter(Collider other)
    {
        // GameObject childGameObject = new GameObject("childGameObject");
        // childGameObject.transform.SetParent(transform);


        if (other.gameObject.tag == "Collectable"&& pos <=4.5f)
        {
            //AttachWithPlayer();
            coinCount += 1;

            //  other.gameObject.SetActive(false);
            Debug.Log("Collected");
        
            //- Used to make the child the coin collide with player
            other.transform.parent = transform; 
            other.transform.position =new Vector3(transform.position.x+pos,transform.position.y+_ypos,transform.position.z);
            pos++; // ----Used for assigning the value of player to the player
            Debug.Log(other.transform.position);
            //--------------------------------------------------------------

        }
         else if (other.gameObject.tag == "Collectable" && pos > 4.5f)
        {
            coinCount += 1;
            other.transform.parent = transform;
            
            other.transform.position =new Vector3(-transform.position.x+_pos,transform.position.y+_ypos,transform.position.z);
            _pos--;
            Debug.Log("Collected");
            Debug.Log(other.transform.position);
            
            // .-.-.-.-.-.-.-.-.-.-.-.-  Used this to print all the childs .-.-.-.-.-.-.-.-.-.-.-.-

            foreach (Transform child in transform)
            {
            Debug.Log(child);
            }
        }

        // else if (other.gameObject.tag == "Collectable" && pos <= -6.80f)
        // {

        // }


        else if (other.gameObject.tag == "Boss")
        {
            coinCount -= 2;
            other.gameObject.SetActive(false);
            Debug.Log("Enemy Boss");
        }
        else if (other.gameObject.tag == "Enemy")
        {
            coinCount -= 1;
            other.gameObject.SetActive(false);
            Debug.Log("Enemy");
        }





    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        turnLeft = Input.GetKeyDown("left");
        turnRight = Input.GetKeyDown("right");

        if (turnLeft)
            transform.Rotate(new Vector3(0f, -90f, 0f));
        else if (turnRight)
            transform.Rotate(new Vector3(0f, 90f, 0f));


        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("jumpanim");
        }

        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;


        if (rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        {
        if (coinCount >= 10)
        SceneManager.LoadScene ("Won");
        }
    }

    // public void AttachWithPlayer()
    // {
    //     Sphere.transform.parent = this.transform;
    // }

}
