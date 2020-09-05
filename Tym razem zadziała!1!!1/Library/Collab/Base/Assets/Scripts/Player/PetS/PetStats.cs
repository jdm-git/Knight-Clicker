using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetStats : MonoBehaviour
{
    public GameObject gameplayscript;
    public Spawner spawnerr;
    public double PetAD = 10;
    public void PetAttack()
    {
        
        spawnerr.TakeDamage(PetAD);

    }
}
