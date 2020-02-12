using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KucukCemberKod : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool HareketKontrol = false;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {   if(!HareketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime); 
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag=="donencember")
        {
            transform.SetParent(col.transform);
            HareketKontrol = true;
        }
    }
}
