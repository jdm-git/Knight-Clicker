using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpgrades : MonoBehaviour
{
    public int koszt = 20;
    public GameplayManager menager;
    public PlayerStats player;
    public float score = 0;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dodajAD()
    {
        score = menager.currentScore;
        if (koszt <= score)
        {
            player.AD += 1;
            menager.currentScore -= koszt;
        }
        else
            Debug.Log("brak hajsu na upgrade");

    }





}
