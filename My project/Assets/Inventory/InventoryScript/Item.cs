using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName ="Inventory/NewItem")]
public class Item :ScriptableObject

{
    public string itemName;
    public Sprite itemImage;
    public int itemHeld;
    [TextArea]
    public string itemText;
     

}
