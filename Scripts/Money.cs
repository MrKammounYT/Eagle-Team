using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{


    public static int money =0;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "" + money;


    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
