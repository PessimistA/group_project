using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class pageScripts : MonoBehaviour
{
    public void buttonpush()//bu fonksiyon herhangi bir butona aktarýlmasa bile zamanlayýcý geri sayým yapacaktýr
    {
        SceneManager.LoadSceneAsync("before 1st page");
    }
    public float targetTime = 5.0f;
    public void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime<=0.0f)
        {
            timerended();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("mainMenu");
        }
    }
    void timerended()
    {
        SceneManager.LoadScene("level1");
    }
}
