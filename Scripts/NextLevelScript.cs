using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevelScript : MonoBehaviour
{

    public Toggle t;
    bool muted = Music.muted;

    void Start()
    {
        t.enabled = muted;

    }
    public void LoadNextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("level" + MenuButtons.nextlevel);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");

    }
    public void restart()
    {
        SceneManager.LoadScene(MenuButtons.getLevel);

    }

    public void MuteButton()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = muted;
        }
        else
        {
            muted = false;
            AudioListener.pause = muted;

        }


    }



}
