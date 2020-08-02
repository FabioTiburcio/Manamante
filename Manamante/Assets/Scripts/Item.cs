using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
    Food,
    Equipment,
    Crafting
}
public class Item : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    public string description;
}
