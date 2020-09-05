using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Nowe Spodnie", menuName = "Ekwipunek/Spodnie")]
public class SpodnieObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.spodnie;
    }
}
