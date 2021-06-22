using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenLeaderboard()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenLevels()
    {
        SceneManager.LoadScene(3);
    }

    /*public void OpenFirstLevel()
    {
        SceneManager.LoadScene(4);
    }*/

}
