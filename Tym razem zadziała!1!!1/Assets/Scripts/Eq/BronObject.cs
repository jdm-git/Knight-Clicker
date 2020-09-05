using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Nowa Bron", menuName = "Ekwipunek/Bron")]
public class BronObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Bron;
    }
}
