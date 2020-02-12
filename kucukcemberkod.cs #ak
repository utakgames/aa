using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcemberkod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool haraketkontrol = false;
    GameObject oy;//oyun yöneticisi=oy
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oy = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
    }

    
    void FixedUpdate ()
    {
        if (!haraketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
        
    }

   void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "donencembertag");
        {
            transform.SetParent(col.transform);
            haraketkontrol = true;
           
        }
        if (col.gameObject.tag=="kucukcembertag")
        {
            oy.GetComponent<oyunyoneticisi>().oyunbitti();
        }
    }
}
