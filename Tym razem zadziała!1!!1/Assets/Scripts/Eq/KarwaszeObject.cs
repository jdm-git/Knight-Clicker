using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nowe Karwasze", menuName = "Ekwipunek/Karwasze")]
public class KarwaszeObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.karwasze;
    }
}
