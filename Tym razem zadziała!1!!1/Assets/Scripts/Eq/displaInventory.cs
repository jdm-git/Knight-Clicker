using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displaInventory : MonoBehaviour
{
    public InventoryObject inventory;

    public int X_START;
    public int Y_START;


    public int X_SPACE_BETW_COL;
    public int Y_SPACE_BETW_COL;
    public int NUMBER_OF_COLUMN;

    List<GameObject> itemsDisplayed = new List<GameObject>(); 

 
    void Start()
    {
        CreateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateDisplay();
    }
    public void CreateDisplay()
    {

        for (int i=0; i<inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            itemsDisplayed.Add(obj);
        }
    }


    public void UpdateDisplay()
    {
        int x = itemsDisplayed.Count;
        Debug.Log(itemsDisplayed);
        for(int i = x; i<inventory.Container.Count; i++)
        {
            
                var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                itemsDisplayed.Add(obj);
  
        }
    }
    public Vector3 GetPosition(int i)
    {
        return new Vector3(X_START + (X_SPACE_BETW_COL * (i%NUMBER_OF_COLUMN)), Y_START+(-Y_SPACE_BETW_COL * (i / NUMBER_OF_COLUMN)), 0f);
    }


}
