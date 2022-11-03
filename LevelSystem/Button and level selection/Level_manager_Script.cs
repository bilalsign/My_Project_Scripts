using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level_manager_Script : MonoBehaviour
{
    public Button[] levelbuttons; //array of buttons_prefabs to manage them
    void Start()
    {
        //GetInt used to set the default value of index.
        //when it starts for the first time or if we clear the playerprefs it will use this value.

        int Level = PlayerPrefs.GetInt("Level", 1);
        for (int i = 0; i < levelbuttons.Length; i++) // i here is the button[] array index
        {
            if (i + 1 > Level) // i +  1 which is 2 .. if 2 [index of button] is greater than the level which is 1 by default. 
            {
                levelbuttons[i].interactable = false; //this will lock the level.
            }
        }


    }

    /* void Update()
     {
         if (Input.GetKeyDown(KeyCode.Q)) // used this to delete the PlayerPrefs Key value.... this clears the current value and switch back to default value.
         {
             PlayerPrefs.DeleteAll();
         }
     }*/





}
