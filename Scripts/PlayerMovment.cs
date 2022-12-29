using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovment : MonoBehaviour
{


    public Rigidbody2D rg;
    public Animator anime;
    public SpriteRenderer sp;
    public Canvas Pause;
    int pressTime = 1;
    public AudioSource pop;
    public AudioSource jump;
    public Canvas GameCanvas;
    public Canvas settings;
    public Text egg,milk,sugar;
    int eggs, milks, sugars = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            rg.velocity = Vector2.right * 15f;
            anime.SetBool("run", true);
            sp.flipX = false;

        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rg.velocity = Vector2.left * 15f;
            anime.SetBool("run", true);
            sp.flipX = true;


        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) 
            || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow) )
        {
            rg.velocity = Vector2.zero;
            anime.SetBool("run", false);



        }
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.UpArrow) && isjumping == false)
        {
            rg.velocity = Vector2.up * height;
            isjumping = true;
            anime.SetBool("isjumping", true);
            jump.Play();

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pressTime == 1)
            {

                Time.timeScale = 0;
                Pause.gameObject.SetActive(true);
                pressTime++;
                GameCanvas.gameObject.SetActive(false);

            }
            else
            {
                Time.timeScale = 1;
                Pause.gameObject.SetActive(false);
                pressTime--;
                GameCanvas.gameObject.SetActive(true);

            }


        }

    }
    bool isjumping = false;
    public float height = 1.2f;
    // Start is called before the first frame update


    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isjumping = false;
            anime.SetBool("isjumping", false);
        }
        if (collision.gameObject.tag == "sugar")
        {
            pop.Play();
            Destroy(collision.gameObject);
            sugars+=1;
            sugar.text = ""+ (int.Parse(sugar.text)+  1);

        }
        if (collision.gameObject.tag == "eggs")
        {
            pop.Play();
            Destroy(collision.gameObject);
            eggs += 1;
            egg.text = "" + (int.Parse(egg.text) + 1);
        }
        if (collision.gameObject.tag == "milk")
        {
            pop.Play();
            Destroy(collision.gameObject);
            milks += 1;
            milk.text = "" + (int.Parse(milk.text) + 1);

        }
    }

    }
