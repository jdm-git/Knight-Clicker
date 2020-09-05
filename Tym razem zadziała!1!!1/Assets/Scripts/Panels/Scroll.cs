using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Scroll : MonoBehaviour
{
    public GameObject container;
    public GameObject scroll;
    double alt;
    public void Start()
    {
        alt = Math.Round(container.transform.position.y);
    }
    // Update is called once per frame
    void Update()
    {
        double updatedAlt = Math.Round(container.transform.position.y);
        if(updatedAlt>alt)
        {
            scroll.SetActive(false);
        }
        else if(updatedAlt<=alt)
        {
            scroll.SetActive(true);
        }

        
    }
}
