using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum ItemType
{
    Bron,
    Buty,
    Nagolenniki,
    karwasze,
    rekawice,
    helm,
    spodnie,
    Klata,
    tarcza

}
public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;
    [TextArea (15,20)]
    public string desription;


}
