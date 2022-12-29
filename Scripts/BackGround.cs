using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGround : MonoBehaviour
{
    // Start is called before the first frame update


    public Renderer rd;
    public float speed;
    ArrayList Trash = new ArrayList();
   public GameObject Player;
    public GameObject obj,obj1, obj2, obj3, obj4, obj5,obj6;
    public Text distance;
    public Canvas hide;
    public Canvas win;
    public AudioSource pop;
    public AudioSource truck;
    public AudioSource winm;
    public GameObject sounds;

    float d = 60;


    void Start()
    {

        Trash.Add(obj);
        Trash.Add(obj1);
        Trash.Add(obj2);
        Trash.Add(obj3);
        Trash.Add(obj4);
        Trash.Add(obj5);
        Trash.Add(obj6);
        StartCoroutine(ExampleCoroutine());
        AudioListener.pause = Music.muted;







    }

    // Update is called once per frame
    void Update()
    {
       
        if (d >= 50)
        {
            rd.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
        }
        else if (d >= 20)
        {
            rd.material.mainTextureOffset += new Vector2(1.5f* speed * Time.deltaTime, 0);

        }
        else 
        {
            rd.material.mainTextureOffset += new Vector2(2f*speed * Time.deltaTime, 0);

        }
       
       
      
            distance.text = Mathf.Round(d)  + " km Left";

        if (d <= 0 && PlayerM.lives > 0)
        {
            //win
            truck.Stop();
            Time.timeScale = 0;
            win.gameObject.SetActive(true);
            hide.gameObject.SetActive(false);
            winm.Play();
            Money.money += 50;
        }
        else
        {
            d -= Time.deltaTime;

        }






    }


  
    IEnumerator ExampleCoroutine()
    {

        int s = Random.Range(2, 5);

        yield return new WaitForSeconds(s);
       

       
        int x = Random.Range(0, 6);
            SpawnItem(x);
            StartCoroutine(ExampleCoroutine());



    }

    
    


    



    void SpawnItem(int r)
    {
        GameObject choosen = (GameObject)Trash[r];
        choosen.SetActive(true);
        Rigidbody2D gm = choosen.gameObject.GetComponent<Rigidbody2D>();
        gm.transform.position = new Vector3(3.9f, -3.12f, -2.27f);
            pop.Play();
    }


}
