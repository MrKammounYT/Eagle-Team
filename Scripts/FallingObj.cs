using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingObj : MonoBehaviour
{

    public GameObject g1, g2, g3;
    public float minx = 0;
    public float maxx = 0;
    public float y = -1;
   ArrayList obj = new ArrayList();
    public Text text;
    public Text milk;
    public Text egg;
    public Canvas GameCanvas;
    public Canvas LoseCanvas;
    public Canvas win;


    public float cooldown = 60;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("spawned!");

        StartCoroutine(startcoldown());
        obj.Add(g1);
        obj.Add(g2);
        obj.Add(g3);

        

        




    }
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            text.text = "00:00";
            if(int.Parse(egg.text) >= 10 || int.Parse(milk.text) >= 10)
            {
                //win
                Time.timeScale = 0;
                GameCanvas.gameObject.SetActive(false);
                win.gameObject.SetActive(true);
                Money.money += 50; 

            }
            else
            {
                //lost
                Time.timeScale = 0;
                GameCanvas.gameObject.SetActive(false);
                LoseCanvas.gameObject.SetActive(true);

            }
        }
        else
        {
            if (Mathf.Round(cooldown) < 10)
            {
                text.text = "00:0" + Mathf.Round(cooldown);

            }
            else
            {
                text.text = "00:" + Mathf.Round(cooldown);
            }
        }


    }


    GameObject lastgm;

    IEnumerator startcoldown()
    {

        yield return new WaitForSeconds(3);
        spawn();
        StartCoroutine(startcoldown());


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Destroy(lastgm);
        }
    }

    public void spawn() {
        int s = Random.Range(0, 2);
     GameObject choosen =(GameObject) obj[s];

    GameObject go = GameObject.Instantiate(choosen);
        float rx = Random.Range(minx, maxx);
        go.transform.position = new Vector3(rx,y,0);
        go.SetActive(true);
        Debug.Log("spawned lc!");
        lastgm = go;


    }

}
