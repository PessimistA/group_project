using System.Collections;
using System.Collections.Generic;
using UnityEngine;//scrMainmenu
using UnityEngine.SceneManagement;

public class scrMainmenu : MonoBehaviour
{
    public void Back(string gameName)
    {
        SceneManager.LoadSceneAsync("openingScene");
    }
    public void quitgame(string gameName)
    {
        Application.Quit();
    }
    public void playScene(string gameName)
    {
        SceneManager.LoadSceneAsync("before 1st page");
    }

    public void levelsScene(string gameName)
    {
        SceneManager.LoadSceneAsync("levels");
    }
    public void sorting(string gameName)
    {
        SceneManager.LoadSceneAsync("sort_bestTOworst");
    }
}