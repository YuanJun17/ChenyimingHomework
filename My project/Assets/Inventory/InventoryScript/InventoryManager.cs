using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager instance;

    public Inventory bag;
    public GameObject slotGrid;
    public slot slotPrefab;
    //public Text itemInfomation;


    public void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        instance = this;
   
    }

    public static void CreateNewItem(Item item)
    {
        slot newItem = Instantiate(instance.slotPrefab, instance.slotGrid.transform.position, Quaternion.identity);
        newItem.gameObject.transform.SetParent(instance.slotGrid.transform);
        newItem.slotItem = item;
        newItem.slotImage.sprite = item.itemImage;
        newItem.slotIndex.text = item.itemHeld.ToString();
    }

}
