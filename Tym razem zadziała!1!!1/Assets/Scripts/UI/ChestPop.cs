using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestPop : MonoBehaviour
{
    public InventoryObject inv;
    public ItemDatabse item;
    public Rigidbody2D rb;
    public Collider2D chest;

    public int x;
    public GameObject okienko;
    void Start()
    {
        rb.AddForce(new Vector2(Random.Range(-100, -50), Random.Range(250, 500)));
        
    }

    public void OnMouseDown()
    {
        x = Random.Range(1, 3);
        inv.AddItem(item.Baza[x]);

        


        Destroy(chest.gameObject);
    }

   
}
