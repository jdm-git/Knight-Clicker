using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nowe Nagolenniki", menuName = "Ekwipunek/Nagolenniki")]
public class NagolennikiObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Nagolenniki;
    }
}
