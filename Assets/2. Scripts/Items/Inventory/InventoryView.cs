using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryView : MonoBehaviour
{
    [SerializeField] private GridLayoutGroup gridGroup;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;
    [SerializeField] private GameObject itemPrefab;
    
    private List<GameObject> items;

    public void CreateGrid(int width, int height)
    {
        // foreach ()
    }
    
}
