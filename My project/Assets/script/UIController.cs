using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public void Awake()
    {
        //if (instance == null)
        //{
            //instance = this;

        //}
        //else if (instance != this)
        //{
            //Destroy(gameObject);
        //}

        //DontDestroyOnLoad(gameObject);
    }
    public Transform playerTransform; // 角色的 Transform
    public Transform uiTransform; // UI的 Transform
    public float verticalOffset = 2.0f; // 垂直偏移量

    private void Update()
    {
        UpdateUIPosition();
    }
    private void UpdateUIPosition()
    {
        if (playerTransform == null || uiTransform == null)
        {
            Debug.LogWarning("Player or UI Transform not assigned.");
            return;
        }

        // 获取角色的位置
        Vector3 playerPosition = playerTransform.position;

        // 计算UI的位置，将UI显示在角色头顶
        Vector3 uiPosition = playerPosition + new Vector3(0f, verticalOffset, 0f);

        // 将UI的位置设置为计算出的位置
        uiTransform.position = uiPosition;
    }
}
