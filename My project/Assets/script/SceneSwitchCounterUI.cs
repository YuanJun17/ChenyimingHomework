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
        // 初始化UI显示为0
        switchCountText.text = "Scene Switch Count: " + LoadManager.instance.switchCount;
    }




}
