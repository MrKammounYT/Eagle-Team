using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    
    public static string getLevel = "level 1";
    public static int nextlevel = 1;
    // Start is called before the first frame update


    
    

    public void LoadLevel1()
    {
        SceneManager.LoadScene("meme");
        getLevel = "level 1";
        nextlevel = 2;

    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("meme");
        getLevel = "level2";
        nextlevel = 3;


    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("meme");
        getLevel = "level3";
        nextlevel = 1;


    }


    public void exit()
    {
        Application.Quit();
    }

}
