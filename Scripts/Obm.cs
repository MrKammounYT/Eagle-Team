using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obm : MonoBehaviour
{


    public GameObject gm;
    public float speed = 1;
    public Transform tr;
    float d = 60;


    // Update is called once per frame
    void Update()
    {
        if(gm.activeSelf == true)
        {
            int x = 1;
            if (d <= 20)
            {
                x = Random.Range(1, 5);
            }
            Rigidbody2D rg= gm.GetComponent<Rigidbody2D>();
            rg.velocity = new Vector2(x*-1 * speed, 0);



        }
        d -= Time.deltaTime;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Border 1" || collision.gameObject.tag == "Player")
        {
            gm.SetActive(false);
            gm.transform.position = new Vector3( 3.9f, -3.12f, -2.27f);
        }
        
    }
    

}
