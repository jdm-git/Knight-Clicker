using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Nowa Baza danych", menuName = "Baza/itemow")]
public class ItemDatabse : ScriptableObject
{
    public List<ItemObject> Baza = new List<ItemObject>();
}
