using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadManager : MonoBehaviour
{
    public int switchCount = 0;

    public static LoadManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this; 

        }
        else if (instance != this)
        {
            Destroy(gameObject); 
        }
        DontDestroyOnLoad(gameObject);
    }



    //“Ï≤Ωº”‘ÿ
    public void Load1()
    {
        
        SceneManager.LoadScene(1);
    }
    public void Load0()
    {
        SceneManager.LoadScene(0);
    }
    public void counttime()
    {
        switchCount++;
    }
}