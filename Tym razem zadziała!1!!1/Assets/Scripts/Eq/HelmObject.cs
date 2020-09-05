using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Nowy Helm", menuName = "Ekwipunek/Helm")]
public class HelmObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.helm;
    }
}
