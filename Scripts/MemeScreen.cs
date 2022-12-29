using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MemeScreen : MonoBehaviour
{

    public Slider slider;
    public float waittimer = 30;
    public Image img1, img2, img3, img4;
    ArrayList img = new ArrayList();
    public AudioSource song;

     void Start()
    {
        img.Add(img1);
        img.Add(img2);
        img.Add(img3);
        img.Add(img4);
        song.Play();
        int ic = Random.Range(0, 4);
      Image selected = (Image)img[ic];
        selected.gameObject.SetActive(true);
            AudioListener.pause = Music.muted;

    }

    void Update() {



        if (waittimer <= 0)
        {
            SceneManager.LoadScene(MenuButtons.getLevel);

        }
        else
        {
            waittimer -= Time.deltaTime;
        }
        slider.value = Mathf.Abs(waittimer);


    }
}
