using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPop : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    float tajmer = 0;
    public Collider2D moneta;
    public int coins = 1;
    private GameplayManager gameplayManager;

    void Awake()
    {
        gameplayManager = GameObject.FindObjectOfType<GameplayManager> ();
    }

    private void OnMouseDown()
    {
        Destroy(moneta.gameObject); //zbieranie coinsow po clicku
        gameplayManager.UpdateCoins(coins);

    }

    public void UpdateCoins(int coins)
    {
        coins += coins;
        
    }


    void Start()
    {
        
        rb.AddForce(new Vector2(Random.Range(-100,100),Random.Range(250,800)));
        
    }

    
    void Update()
    {
        if(gameplayManager.currentStage == 0)
        {
            coins = 1;
        }
        else
        {
            coins = gameplayManager.currentStage; //Przyrost coinsow wraz z stage'em
        }
        tajmer += Time.deltaTime;
        if(tajmer>4)
        {
            for(int i=0;i< GameObject.FindGameObjectsWithTag("Coin").Length-1;i++)
                gameplayManager.UpdateCoins(coins); //automatycznie zbieranie coinsow po 4s


            Destroy(GameObject.FindGameObjectWithTag("Coin"));
            
            
        }
    }
}   
