using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepStill : MonoBehaviour
{
    public static KeepStill instance;
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
