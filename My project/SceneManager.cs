using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadSceneManager
{
    private static LoadSceneManager instance;
    public static LoadSceneManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new LoadSceneManager();
            }
            return instance;
        }
    }

    public string nextSceneName;

    //“Ï≤Ωº”‘ÿ
    public void LoadScene1()
    {
        Debug.Log("LoadSceneAsync:" + sceneName);
        nextSceneName = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }
    public void LoadScene(string sceneName)
    {
        Debug.Log("LoadScene:" + sceneName);
        SceneManager.LoadScene(sceneName);
    }

}