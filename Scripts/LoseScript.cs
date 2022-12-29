using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour
{
   

    public void Restart()
    {
        SceneManager.LoadScene("level 1");
        Time.timeScale = 1;


    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");

    }





}
