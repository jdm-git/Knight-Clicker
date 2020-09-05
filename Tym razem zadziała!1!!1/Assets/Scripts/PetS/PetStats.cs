using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    public GameObject gameplayscript;
    public Spawner spawnerr;
    
    public float PetAD = 10f;
    
    public float Pet2AD = 15f;
    public void PetAttack()
    {
        
        spawnerr.TakeDamage(PetAD);

    }

    public void Pet2Attack()
    {

        spawnerr.TakeDamage(Pet2AD);

    }

    public void Start()
    {
        if(PlayerPrefs.HasKey("PetAd"))
        {
            PetAD = PlayerPrefs.GetFloat("PetAd");
        }
        else
        {
            PetAD = 10f;
        }

        if (PlayerPrefs.HasKey("Pet2Ad"))
        {
            Pet2AD = PlayerPrefs.GetFloat("Pet2Ad");
        }
        else
        {
            Pet2AD = 15f;
        }
    }
}
