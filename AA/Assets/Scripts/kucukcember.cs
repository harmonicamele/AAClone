using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcember : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketkontrol = false;
    GameObject Oyunyoneticisi; 

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        Oyunyoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");   

    }

    
    void FixedUpdate()

    {
        if(!hareketkontrol)  
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);   

        }
        
            
    }
    private void OnTriggerEnter2D(Collider2D collision)  

    {
        if(collision.tag=="donencembertag")  
        {
            transform.SetParent(collision.transform );   
            hareketkontrol = true;  
        }
        if (collision.tag=="kucukcembertag")  
        {
            
            Oyunyoneticisi.GetComponent<oyunyoneticisi>().OyunBitti(); 
        }
    }
}
