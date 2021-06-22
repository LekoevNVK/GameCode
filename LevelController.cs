using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    int sceneIndex;
    int levelComplete = 4;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex + 0;
        levelComplete = PlayerPrefs.GetInt("levelComplete");
    }
    public void isEndGame()
    {
        if (sceneIndex == 6)
        {
            Invoke("LoadMainMenu", 1f);
        }
        else
        {
            if(levelComplete < sceneIndex)
            {
                PlayerPrefs.SetInt("levelComplete", sceneIndex);
            }
            Invoke("NextLevel", 1f);
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("Main_menu");
    }
}
