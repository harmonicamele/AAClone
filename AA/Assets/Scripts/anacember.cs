using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacember : MonoBehaviour
{
    public GameObject kucukcember;  //prefaba tanımladık sürekleyip bırakıcaz
    GameObject Oyunyonetici;
    void Start()
    {
        Oyunyonetici  = GameObject.FindGameObjectWithTag  ("oyunyoneticisitag");

    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))   //mausa tıkladığımızda 
        {
            kucukcemberolustur(); 
        }
    }
    void kucukcemberolustur()  //oluşturma işini instantiate yapıyor üç paramatre alıyor
    {
        Instantiate(kucukcember,transform.position,transform.rotation ); // objemiz objemizin poziyonu ve rotasyonu
        Oyunyonetici.GetComponent<oyunyoneticisi>().kucukcemberlerdetextgoster() ;                 //oyun yöneticisinden metodu çağırıyoruz

    }
    

}
