using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;   

public class oyunyoneticisi : MonoBehaviour
{
    GameObject donencember;
    GameObject Anacember;
    public Animator animator; 
    public Text  donencemberlevel;   
    public Text bir;
    public Text iki;
    public Text  uc;
    public int kactanekucukcemberolsun;
    bool kontrol = true; 


    void Start()
    {
        PlayerPrefs.SetInt("kayit", int.Parse(SceneManager.GetActiveScene().name));   

        donencember = GameObject.FindGameObjectWithTag("donencembertag");
        Anacember  = GameObject.FindGameObjectWithTag("anacembertag");
        donencemberlevel.text = SceneManager.GetActiveScene().name; 

        if (kactanekucukcemberolsun < 2)
        {
            bir.text = kactanekucukcemberolsun + "";   
        }
        else if (kactanekucukcemberolsun < 3)
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = (kactanekucukcemberolsun - 1) + "";   
        }
        else
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = (kactanekucukcemberolsun - 1) + "";
            uc.text = (kactanekucukcemberolsun - 2) + "";
        }
    }
    public void kucukcemberlerdetextgoster()    
    {
        kactanekucukcemberolsun--;  
        if (kactanekucukcemberolsun < 2)
        {
            
            bir.text = kactanekucukcemberolsun + "";
            iki.text = "";
            uc.text = "";
        }
        else if (kactanekucukcemberolsun < 3)
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = (kactanekucukcemberolsun - 1) + "";
            uc.text = "";
        }
        else
        {
            bir.text = kactanekucukcemberolsun + "";
            iki.text = (kactanekucukcemberolsun - 1) + "";
            uc.text = (kactanekucukcemberolsun - 2) + "";
        }
        if (kactanekucukcemberolsun == 0)  
        {
            
            StartCoroutine(yenilevel());    
        }
    }
    IEnumerator  yenilevel()    
    {
        donencember.GetComponent<Dondurme>().enabled = false;     
        Anacember.GetComponent<anacember>().enabled = false;
        yield return new WaitForSeconds(0.5f);

        
        if (kontrol) 
        {
            animator.SetTrigger("YeniLevel");

            yield return new WaitForSeconds(1.5f); 
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        
        }
        
    }

    public void OyunBitti()
    {
        StartCoroutine(cagırılanmetot());   
        
    }
    IEnumerator  cagırılanmetot()   
    {
        donencember.GetComponent<Dondurme>().enabled = false;     
        Anacember.GetComponent<anacember >().enabled = false;
        animator.SetTrigger("oyunbitti");   
        kontrol = false;
      
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Game");


    }
}
