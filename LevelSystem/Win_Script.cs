using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Win_Script : MonoBehaviour
{
    public int LoadNextLevel;
    public Button[] levelButtons;
    public Text leveltext;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.DeleteAll();
        LoadNextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        



        int CurrentLevel = PlayerPrefs.GetInt("CurrentLevel");
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 2 > CurrentLevel)
            {
                levelButtons[i].interactable = false;
            }
        }
        
        LevelNameDisplay();

    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(LoadNextLevel);
        if (LoadNextLevel > PlayerPrefs.GetInt("CurrentLevel"))
        {
            PlayerPrefs.SetInt("CurrentLevel", LoadNextLevel);
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel"));
    }

    public void LevelNameDisplay()
    {
    leveltext.text = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }

    public void Click_Home()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ChangeLevel(int LevelIndex)
    {
        SceneManager.LoadScene(LevelIndex);
    }
}
