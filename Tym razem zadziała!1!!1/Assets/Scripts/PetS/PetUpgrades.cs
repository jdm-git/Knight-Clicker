using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetUpgrades : MonoBehaviour
{
    public PetStats pet1Stats;
    public PetStats pet2Stats;

    private int kosztPet1 = 20;
    private int kosztPet2 = 40;
    public GameplayManager gampleyManager;
    private float money = 0;

    public Text UpgradePetText;
    public Text UpgradePet2Text;
    // Start is called before the first frame update
    void Start()
    {
        //Pet 1
        if (PlayerPrefs.HasKey("Pet1UpgradeCost"))
        {
            PlayerPrefs.SetInt("Pet1UpgradeCost", PlayerPrefs.GetInt("Pet1UpgradeCost"));
            Debug.Log(kosztPet1);
        }
        else
        {
            PlayerPrefs.SetInt("Pet1UpgradeCost", kosztPet1);
            Debug.Log(kosztPet1);
        }
        UpgradePetText.text = "Upgrade : " + PlayerPrefs.GetInt("Pet1UpgradeCost").ToString();

        if (PlayerPrefs.HasKey("PetAd"))
        {
            pet1Stats.PetAD = PlayerPrefs.GetFloat("PetAd");
        }

        //Pet 2 -----------------------------------------------------------------------------------------------
        if (PlayerPrefs.HasKey("Pet2UpgradeCost"))
        {
            PlayerPrefs.SetInt("Pet2UpgradeCost", PlayerPrefs.GetInt("Pet2UpgradeCost"));
            Debug.Log(kosztPet2);
        }
        else
        {
            PlayerPrefs.SetInt("Pet2UpgradeCost", kosztPet2);
            Debug.Log(kosztPet2);
        }
        UpgradePet2Text.text = "Upgrade : " + PlayerPrefs.GetInt("Pet2UpgradeCost").ToString();

        if (PlayerPrefs.HasKey("Pet2Ad"))
        {
            pet2Stats.Pet2AD = PlayerPrefs.GetFloat("Pet2Ad");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpgradePet() //Upgrade Peta (Dodaje petowi DMG)
    {
        money = gampleyManager.currentCoins;
        kosztPet1 = PlayerPrefs.GetInt("Pet1UpgradeCost");
        if (kosztPet1 <= money)
        {

            if (PlayerPrefs.HasKey("PetAd"))
            {
                PlayerPrefs.SetFloat("PetAd", PlayerPrefs.GetFloat("PetAd") * 1.5f);
                pet1Stats.PetAD = PlayerPrefs.GetFloat("PetAd");
            }
            else
            {
                PlayerPrefs.SetFloat("PetAd", 10 * 1.5f);
                pet1Stats.PetAD = PlayerPrefs.GetFloat("PetAd");
            }
            gampleyManager.currentCoins -= kosztPet1;
            kosztPet1 *= 2;
            PlayerPrefs.SetInt("Pet1UpgradeCost", kosztPet1);
            UpgradePetText.text = "Upgrade : " + kosztPet1;
            gampleyManager.UpdateCoins(0);

        }
        else
        {
            Debug.Log("no funds");
        }
    }
 //---------------------------------------------------------------------------------------------------------Pet2
    public void UpgradePet2() //Upgrade Peta (Dodaje petowi DMG)
    {
        money = gampleyManager.currentCoins;
        kosztPet2 = PlayerPrefs.GetInt("Pet2UpgradeCost");
        if (kosztPet2 <= money)
        {

            if (PlayerPrefs.HasKey("Pet2Ad"))
            {
                PlayerPrefs.SetFloat("Pet2Ad", PlayerPrefs.GetFloat("Pet2Ad") * 1.5f);
                pet2Stats.Pet2AD = PlayerPrefs.GetFloat("Pet2Ad");
            }
            else
            {
                PlayerPrefs.SetFloat("Pet2Ad", 15 * 1.5f);
                pet2Stats.Pet2AD = PlayerPrefs.GetFloat("Pet2Ad");
            }
            gampleyManager.currentCoins -= kosztPet2;
            kosztPet2 *= 2;
            PlayerPrefs.SetInt("Pet2UpgradeCost", kosztPet2);
            UpgradePet2Text.text = "Upgrade : " + kosztPet2;
            gampleyManager.UpdateCoins(0);

        }
        else
        {
            Debug.Log("no funds");
        }
    }
}
