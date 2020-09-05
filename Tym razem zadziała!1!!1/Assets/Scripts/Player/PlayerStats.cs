using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Spawner spawnerr;
    public float HeroHP = 120;
    public float HeroAD = 40f;
    public double HeroCurrentHP;
    private double CritChance = 0.5;
    private double CritDamage = 1.5;
    private double DodgeChance = 0.5;
    public Text HeroDMGtext;
    public bool ifcrit = false;
    public List<string> unlockedSkills = new List<string>();
    

    void Start()
    {
        HeroCurrentHP = HeroHP;
    }

    public void Attack()
    {
        if (CritChance > Random.Range(0, 101))
        {
            ifcrit = true;
            spawnerr.TakeDamage(HeroAD * CritDamage); //Atak boha w enemy
        }
        else
        {
            ifcrit = false;
            spawnerr.TakeDamage(HeroAD);
        }
    }

    void Update()
    {
        if(HeroCurrentHP < HeroHP)
        HeroCurrentHP += 5 * Time.deltaTime; //Regeneracja HP


    }

    public void TakeDamage(double damage) //Przyjęcie obrażeń
    {
        if (DodgeChance > Random.Range(0, 101)) //Mechanika Dodge
        {
            HeroDMGtext.enabled = true;
            HeroDMGtext.text = "*Dodge*";
            Invoke("DelayIndicator", 0.25f);
        }
        else
        {
            HeroCurrentHP -= damage;
            HeroDMGtext.enabled = true;
            HeroDMGtext.text = "-" + damage;
            Invoke("DelayIndicator", 0.25f);
        }
    }
    public void DelayIndicator()
    {
        HeroDMGtext.enabled = false;

    }
}
