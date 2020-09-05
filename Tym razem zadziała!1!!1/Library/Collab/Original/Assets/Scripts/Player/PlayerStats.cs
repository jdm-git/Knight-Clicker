using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Spawner spawnerr;
    public float HeroHP = 120;
    public float HeroAD = 40f;
    public double HeroCurrentHP;
    public Text HeroDMGtext;

    public void Attack()
    {

        spawnerr.TakeDamage(HeroAD); //Atak boha w enemy


    }

    void Start()
    {
        HeroCurrentHP = HeroHP;
        


    }


    void Update()
    {
        if(HeroCurrentHP < HeroHP)
        HeroCurrentHP += 5 * Time.deltaTime;


    }

    public void TakeDamage(double damage)
    {
            HeroCurrentHP -= damage;
        HeroDMGtext.enabled = true;
        HeroDMGtext.text = "-" + damage;
        Invoke("DelayIndicator", 0.25f);

    }
    public void DelayIndicator()
    {

        HeroDMGtext.enabled = false;

    }
}
