using UnityEngine;
using UnityEngine.UI;

public class PlayerUpgrades : MonoBehaviour
{
    [HideInInspector]
    public int koszt = 20;
    [HideInInspector]
    public GameplayManager gampleyManager;
    public Slider slider;
    public Text weaponUpgradeValue;
    public PlayerStats player;
    [HideInInspector]
    public float money = 0;


    public void Start()
    {

        if (PlayerPrefs.HasKey("Koszt"))
        {
            PlayerPrefs.SetInt("Koszt", PlayerPrefs.GetInt("Koszt"));
        }
        else
        {
            PlayerPrefs.SetInt("Koszt", koszt);
        }
        weaponUpgradeValue.text = "Buy:" + PlayerPrefs.GetInt("Koszt").ToString();

   

        if (PlayerPrefs.HasKey("PlayerAd"))
        {
            player.HeroAD = PlayerPrefs.GetFloat("PlayerAd");
        }
        if (PlayerPrefs.HasKey("PlayerAd"))
        {
            player.HeroHP = PlayerPrefs.GetFloat("PlayerHp");
        }
    }

    public void UpgradeAttackDamage() //Upgrade bohatera (Dodaje DMG jak na razie)
    {
        money = gampleyManager.currentCoins;
        if (PlayerPrefs.HasKey("Koszt"))
        {
            PlayerPrefs.SetInt("Koszt", PlayerPrefs.GetInt("Koszt"));
        }
        else
        {
            PlayerPrefs.SetInt("Koszt", koszt);
        }
        koszt = PlayerPrefs.GetInt("Koszt");
        if (koszt <= money)
        {
            koszt = PlayerPrefs.GetInt("Koszt");
            player.HeroAD *= 1.4f;
            player.HeroHP *= 1.4f;
            slider.maxValue = (float)player.HeroHP;
            gampleyManager.currentCoins -= koszt;
            koszt *= 2;
            PlayerPrefs.SetInt("Koszt", koszt);
            gampleyManager.UpdateCoins(0);
            PlayerPrefs.SetFloat("PlayerAd", player.HeroAD);
            PlayerPrefs.SetFloat("PlayerHp", player.HeroHP);
        }
        else
        {
            Debug.Log("No funds");
        }
    }

    public void UpdateCost() 
    {
        weaponUpgradeValue.text = "Buy:" + koszt.ToString();
    }

  


}
