using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerPref_Script : MonoBehaviour
{/*
    public Text Score;
    public Text HighScore;
    static int i=0;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* Highscore();
        HighScore.text = PlayerPrefs.GetInt("HighScore : ").ToString();*/
    }
  /*  public void Play()
    {
        i +=1; 
        Score.text = i.ToString();
        PlayerPrefs.SetInt("Score",i);
       
    }*/

   /* public void Highscore()
    {
        if (PlayerPrefs.GetInt("Score")>PlayerPrefs.GetInt("HighScore : "))
        {
            int highScoree = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("HighScore : ", highScoree);
        }

       

    }*/
   


}
