using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform target; // ��ɫ��Transform���
    public float smoothSpeed = 0.125f; // ������ƶ���ƽ���ٶ�
    public Vector3 offset; // ������ͽ�ɫ֮���ƫ��

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
