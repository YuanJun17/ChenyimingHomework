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
    public Transform playerTransform; // ��ɫ�� Transform
    public Transform uiTransform; // UI�� Transform
    public float verticalOffset = 2.0f; // ��ֱƫ����

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

        // ��ȡ��ɫ��λ��
        Vector3 playerPosition = playerTransform.position;

        // ����UI��λ�ã���UI��ʾ�ڽ�ɫͷ��
        Vector3 uiPosition = playerPosition + new Vector3(0f, verticalOffset, 0f);

        // ��UI��λ������Ϊ�������λ��
        uiTransform.position = uiPosition;
    }
}
