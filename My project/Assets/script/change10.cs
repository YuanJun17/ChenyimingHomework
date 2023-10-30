using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change10 : MonoBehaviour
{
    private SceneSwitchCounterUI counterUI;
    // Start is called before the first frame update
    void Start()
    {
        counterUI = FindObjectOfType<SceneSwitchCounterUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")
            && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            LoadManager.instance.Load0();
            LoadManager.instance.counttime();
        }
    }
}