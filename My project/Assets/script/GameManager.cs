using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Rigidbody2D myrigidbody;
    public Animator myanim;
    public static GameManager instance; // 静态实例，用于实现单例模式


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }


}
