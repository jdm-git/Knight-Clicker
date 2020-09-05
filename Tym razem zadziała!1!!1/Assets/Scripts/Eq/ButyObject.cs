using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nowe Buty", menuName = "Ekwipunek/Buty")]
public class ButyObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Buty;
    }
}
