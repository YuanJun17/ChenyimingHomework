using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ItemLogic : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;


    public void AddNewItem()
    {
        if (!playerInventory.itemList.Contains(thisItem))
        {
            playerInventory.itemList.Add(thisItem);
            InventoryManager.CreateNewItem(thisItem);
        }
        else
        {
            thisItem.itemHeld++;
        }
    }
    public static void SpawnItemX(Vector3 spawnPosition)
    {
        GameObject itemX = Instantiate(Resources.Load("ItemXPrefab") as GameObject, spawnPosition, Quaternion.identity);
        ItemLogic itemXScript = itemX.GetComponent<ItemLogic>();
        if (itemXScript != null)
        {
            itemXScript.Reset();
        }

    }

    public static void SpawnItemO(Vector3 spawnPosition)
    {
        GameObject itemO = Instantiate(Resources.Load("ItemOPrefab") as GameObject, spawnPosition, Quaternion.identity);
        ItemLogic itemOScript = itemO.GetComponent<ItemLogic>();
        if (itemOScript != null)
        {
            itemOScript.Reset();
        }

    }

    public static void SpawnItemTriangle(Vector3 spawnPosition)
    {
        GameObject itemTriangle = Instantiate(Resources.Load("ItemTrianglePrefab") as GameObject, spawnPosition, Quaternion.identity);
        ItemLogic itemTriangleScript = itemTriangle.GetComponent<ItemLogic>();
        if (itemTriangle != null)
        {
            itemTriangleScript.Reset();
        }

    }

    public static void SpawnItemSquare(Vector3 spawnPosition)
    {
        GameObject itemSquare = Instantiate(Resources.Load("ItemSquarePrefab") as GameObject, spawnPosition, Quaternion.identity);
        ItemLogic itemSquareScript = itemSquare.GetComponent<ItemLogic>();
        if (itemSquare != null)
        {
            itemSquareScript.Reset();
        }

    }

    public void Reset()
    {
        // 在这里可以进行任何需要的初始化操作
    }
    // 当道具被拾取时调用
    public void PickUp()
    {
        Destroy(gameObject);
    }
    
}
