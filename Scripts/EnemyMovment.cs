using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{


    public Rigidbody2D rg;
    public SpriteRenderer sp;
    Vector2 v;
    public Animator anime;
    int health = 4;


    private void Start()
    {
        v = Vector2.left ;
    }

    // Update is called once per frame
    void Update()
    {

        rg.velocity = v;
        anime.SetBool("run", true);
      
     
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            v = Vector2.right;
            sp.flipX = true;
        }
        if (collision.gameObject.tag == "wall2")
        {
            v = Vector2.left;
            sp.flipX = false;

        }
        if (collision.gameObject.tag == "Player")
        {
            anime.SetBool("inFight", true);
            Debug.Log("fight");
        }

        if (collision.gameObject.tag == "PlayerLegs")
        {
            anime.SetBool("damaged", true);
            health--;

        }
    }
}
