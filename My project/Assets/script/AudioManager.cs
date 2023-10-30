using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance; // ��̬ʵ��������ʵ�ֵ���ģʽ

    
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
