using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    GameObject player;
    GameObject gameplayscript;
    private double EnemyAD;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag("Player");
        gameplayscript = GameObject.FindWithTag("gameplayscript");
        EnemyAD=gameplayscript.GetComponent<Spawner>().EnemyAD;

        

    }


    void Update()
    {
        
    }

    public void Attack()
    {

        player.GetComponent<PlayerStats>().TakeDamage(EnemyAD); //Atak potwora w boha

    }


}
