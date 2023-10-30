using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance; // 静态实例，用于实现单例模式

    
    public AudioSource footstepSoundSource1;


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

    public void PlayFootstepSound1()
    {
        footstepSoundSource1.Play();
    }
}
