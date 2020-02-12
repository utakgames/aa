using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacemberkod : MonoBehaviour
{
    public GameObject a;//a=küçük çember
    GameObject oyunyonet;
    void Start()
    {
        oyunyonet = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }
     void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            kucukcemberolustur();
        }  
    }
    void kucukcemberolustur()
    {
        Instantiate(a, transform.position, transform.rotation);
        oyunyonet.GetComponent<oyunyoneticisi>().kucukcembertext();
    }

}
