using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class CharaterController : MonoBehaviour
{

    public GameObject itemXPrefab;
    public Vector3 playerPosition;


    // Start is called before the first frame update
    void Start()
    {
        
        playerPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = transform.position;

        // ���� "1" ������������
        if (Input.GetKeyDown(KeyCode.Alpha1)  && GameManager.instance.ItemXCount <2 && GameManager.instance.hasItemXPickedUp)
        {
            DropItemX();
            
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && GameManager.instance.ItemOCount < 2 && GameManager.instance.hasItemOPickedUp)
        {
            DropItemO();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && GameManager.instance.ItemTriangleCount < 2 && GameManager.instance.hasItemTrianglePickedUp)
        {
            DropItemTriangle();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && GameManager.instance.ItemSquareCount < 2 && GameManager.instance.hasItemSquarePickedUp)
        {
            DropItemSquare();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        // ����ɫ�������ײʱ
        ItemLogic item = other.GetComponent<ItemLogic>();

        if (item != null && other.gameObject.CompareTag("ItemX"))
        {
            // ��ɫʰȡ����
            item.AddNewItem();
            item.PickUp();
            GameManager.instance.ItemXCount--;
            GameManager.instance.hasItemXPickedUp = true;
        }

        if (item != null && other.gameObject.CompareTag("ItemO"))
        {
            // ��ɫʰȡ����
            item.AddNewItem();
            item.PickUp();
            GameManager.instance.ItemOCount--;
            GameManager.instance.hasItemOPickedUp = true;
        }


        if (item != null && other.gameObject.CompareTag("ItemTriangle"))
        {
            // ��ɫʰȡ����
            item.AddNewItem();
            item.PickUp();
            GameManager.instance.ItemTriangleCount--;
            GameManager.instance.hasItemTrianglePickedUp = true;
        }

        if (item != null && other.gameObject.CompareTag("ItemSquare"))
        {
            // ��ɫʰȡ����
            item.AddNewItem();
            item.PickUp();
            GameManager.instance.ItemSquareCount--;
            GameManager.instance.hasItemSquarePickedUp = true;
        }
    }



    // ��������
    private void DropItemX()
    {

        Vector3 dropPosition = playerPosition + new Vector3(2f,0f,0f);

        ItemLogic.SpawnItemX(dropPosition);
        GameManager.instance.ItemXCount++;
        
    }
    private void DropItemO()
    {
        Vector3 dropPosition = playerPosition + new Vector3(2f, 0f, 0f);

        ItemLogic.SpawnItemO(dropPosition);
        GameManager.instance.ItemOCount++;
    }

    private void DropItemTriangle()
    {
        Vector3 dropPosition = playerPosition + new Vector3(2f, 0f, 0f);

        ItemLogic.SpawnItemTriangle(dropPosition);
        GameManager.instance.ItemTriangleCount++;
    }
    private void DropItemSquare()
    {
        Vector3 dropPosition = playerPosition + new Vector3(2f, 0f, 0f);

        ItemLogic.SpawnItemSquare(dropPosition);
        GameManager.instance.ItemSquareCount++;
    }

}
