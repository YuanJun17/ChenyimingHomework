using UnityEngine;
using UnityEngine.UI;

public class SceneSwitchCounterUI : MonoBehaviour
{
    public Text switchCountText;

    public void Update()
    {
       
    }
    public void Start()
    {
        // ��ʼ��UI��ʾΪ0
        switchCountText.text = "Scene Switch Count: " + LoadManager.instance.switchCount;
    }




}
