using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel_Script : MonoBehaviour
{
    public int loadnextScene;
    
    void Start()
    {
       
        // here the value of loadnextScene will be current index + 1  which will be 2. it will load next level.


        loadnextScene = SceneManager.GetActiveScene().buildIndex + 1;


       // printPlayerPrefs(); // calling the print function to print GETINT "Level" value on console
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //if the player hits this gameobject... the next Scene will be loaded.
            SceneManager.LoadScene(loadnextScene);

            if (loadnextScene > PlayerPrefs.GetInt("Level")) // this will compare the the buildindex with GetInt("Level")   
            {
                PlayerPrefs.SetInt("Level", loadnextScene);
            }
        }
    }

    // int nextLevelIndex < used on buttons.   manually added values on buttons. used to load level.
    public void ChangeScene(int nextLevelIndex)
    {
        SceneManager.LoadScene(nextLevelIndex);
    }

  /* void printPlayerPrefs()
    {
        print(PlayerPrefs.GetInt("Level"));  
        // used this line to print the current value of GETINT("Level") after increment which i declared 1 as default.
    }*/
}
