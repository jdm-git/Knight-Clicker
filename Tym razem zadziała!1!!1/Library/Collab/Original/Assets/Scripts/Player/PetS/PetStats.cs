using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    public GameObject gameplayscript;
    public Spawner spawnerr;
    public float PetAD = 30f;
    public void PetAttack()
    {
        
        spawnerr.TakeDamage(PetAD);

    }
    public void Update()
    {
        if(PlayerPrefs.HasKey("PetAd"))
        {
            PetAD = PlayerPrefs.GetFloat("PetAd");
        }
        else
        {
            PetAD = 10f;
        }
    }
}
