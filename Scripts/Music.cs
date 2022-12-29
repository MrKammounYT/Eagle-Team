using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public static bool muted = false;
    public Toggle toggle;

  
    public void MuteButton()
    {
        if(muted == false)
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
