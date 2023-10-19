using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnKeyPress : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode playSoundKey = KeyCode.D; // 指定播放声音的键
    public AudioSource soundSource; // 声音源组件，用于播放声音
    private bool isPlaying = false; // 用于检测声音是否正在播放

    // Update is called once per frame
    void Update()
    {
        // 检查键盘输入是否按下了指定的键
        if (Input.GetKeyDown(playSoundKey))
        {
            // 如果声音没有正在播放，就开始播放声音
            if (!isPlaying && soundSource != null)
            {
                soundSource.Play();
                isPlaying = true;
            }
        }
    }
}
