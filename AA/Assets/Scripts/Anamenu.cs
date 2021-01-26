using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   

public class Anamenu : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.DeleteAll();
    }
    public void Oyunagit()
    {
        int kayitlilevel = PlayerPrefs.GetInt("kayit");  

        if (kayitlilevel==0 )
        {
            SceneManager.LoadScene(kayitlilevel + 1);
        }
        else
        {
            SceneManager.LoadScene(kayitlilevel);
        }
    }
    public void Defol()
    {
        Application.Quit();
        
    }

}
