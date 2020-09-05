using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nowa Klata", menuName = "Ekwipunek/Klata")]
public class KlataObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Klata;
    }
}
