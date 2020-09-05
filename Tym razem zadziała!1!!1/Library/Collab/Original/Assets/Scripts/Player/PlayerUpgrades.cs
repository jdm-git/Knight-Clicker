using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpgrades : MonoBehaviour
{
    public int koszt = 20;
    public GameplayManager menager;
    public PlayerStats player;
    public float score = 0;


    public void dodajAD()
    {
        player.AD += 10;
    }





}
