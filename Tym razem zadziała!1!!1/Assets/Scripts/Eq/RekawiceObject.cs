using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nowe Rekawice", menuName = "Ekwipunek/Rekawice")]
public class RekawiceObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.rekawice;
    }
}
