using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    public Button level2;
    public Button level3;
    public Button level4;
    public Button level5;
    public Button level6;
    public Button level7;
    public Button level8;
    int levelComplete;
    private void Start()
    {
        levelComplete = PlayerPrefs.GetInt("levelComplete");
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
        level5.interactable = false;
        level6.interactable = false;
        level7.interactable = false;
        level8.interactable = false;

        switch (levelComplete)
        {
            case 4:
                level2.interactable = true;
                break;
            case 5:
                level2.interactable = true;
                level3.interactable = true;
                break;
            case 6:
                level2.interactable = true;
                level3.interactable = true;
                level4.interactable = false;
                break;
        }
    }
    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Reset()
    {
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
