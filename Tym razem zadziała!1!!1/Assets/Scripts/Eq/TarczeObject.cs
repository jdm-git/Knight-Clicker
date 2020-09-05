using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nowa Tarcza", menuName = "Ekwipunek/Tarcza")]
public class TarczeObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.tarcza;
    }
}
