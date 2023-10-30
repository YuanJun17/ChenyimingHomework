using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollow : MonoBehaviour
{
    public Transform target; // 角色的Transform组件
    public float smoothSpeed = 0.125f; // 摄像机移动的平滑速度
    public Vector3 offset; // 摄像机和角色之间的偏移

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
