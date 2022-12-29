using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerM : MonoBehaviour
{


    public static int lives = 3;
    public GameObject sp1,sp2,sp3;
    int pressTime = 1;
    bool jump = false;
    public Rigidbody2D rg;
    public float JumpHight = 2f;
    public Animator anime;
    public Canvas Pause;
    public Canvas GameCanvas;
    public Canvas LoseCanvas;
    public AudioSource audio;
    public AudioSource hurt;
    public Canvas settings;

    // Update is called once per frame
    void Update()
    {

        if((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) )&& jump == false)
        {
            rg.velocity = Vector2.up * JumpHight;
            jump = true;
            anime.SetBool("isjumping", true);
        
                audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pressTime == 1)
            {

                Time.timeScale = 0;
                Pause.gameObject.SetActive(true);
                pressTime++;
                Pause.gameObject.SetActive(true);
                settings.gameObject.SetActive(false);

            }
            else
            {
                Time.timeScale = 1;
                Pause.gameObject.SetActive(false);
                pressTime--;
                Pause.gameObject.SetActive(false);
                settings.gameObject.SetActive(false);
            }


        }

        
    }



    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }





    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Objects")
        {

            if (lives == 3)
            {
                sp1.gameObject.SetActive(false);
               
               
            }
            else if (lives == 2)
            {
                sp2.gameObject.SetActive(false);
                
            }
            else 
            {
                anime.SetBool("dead", true);
                sp3.gameObject.SetActive(false);
                StartCoroutine(ExampleCoroutine());
               

                // lose menu
            }
            lives--;

            collision.gameObject.SetActive(false);
            collision.transform.position = new Vector3(3.9f, -3.12f, -2.27f);
            hurt.Play();

        }
        if (collision.gameObject.tag == "Ground")
        {
            jump = false;
            anime.SetBool("isjumping", false);
        }
    }

    public void OpenLoseMenu()
    {
        GameCanvas.gameObject.SetActive(false);
        Time.timeScale = 0;
        LoseCanvas.gameObject.SetActive(true);
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);

        OpenLoseMenu();



    }
    

}
