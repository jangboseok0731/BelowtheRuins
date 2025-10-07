using UnityEngine;

public enum ItemType
{
    Head,
    Shoulder,
    Weapon,
    Armor,
    Belt,
    Legs,
    Shoes,
    Gauntlet,
    Pendant,
    Ring,
    Wrist,
    Orb,
    Consumable
}

[CreateAssetMenu(fileName = "ItemData", menuName = "Inventory/Items")]
public class ItemData : ScriptableObject
{
    [Header("Infomation")]
    public string name;
    public Sprite icon;
    public ItemType type;

    [TextArea]
    public string description;

    [Header("Status")]
    public int speed;
    
    [Header("InventorySpace")]
    public Vector2Int size = new Vector2Int(1, 1);
    public bool stackable;
    public int maxStack;
}

[System.Serializable]
public class Item
{
    public ItemData data;
    public int quantity;

    public Item(ItemData data, int quantity)
    {
        this.data = data;
        this.quantity = quantity;
    }
}
 