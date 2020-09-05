using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetSpawner : MonoBehaviour
{
    public GameplayManager gameplayManager;

    public GameObject PetUpgradeButton;
    public GameObject Pet2UpgradeButton;

    public GameObject pet1;
    public GameObject pet2;

    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.HasKey("petExist")) //Sprawdza czy Pet istnieje (jeżeli tak to jest upgrade button, jeśli nie, buy button)
        {
            pet1.SetActive(true);
            GameObject.Find("Buy Pet Button").SetActive(false);
            PetUpgradeButton.SetActive(true);
        }
        if (PlayerPrefs.HasKey("pet2Exist")) //Sprawdza czy Pet istnieje (jeżeli tak to jest upgrade button, jeśli nie, buy button)
        {
            pet2.SetActive(true);
            GameObject.Find("Buy Pet2 Button").SetActive(false);
            Pet2UpgradeButton.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void SpawnPet1()
    {
        if (gameplayManager.currentCoins >= 20)
        {
            pet1.SetActive(true);
            GameObject.Find("Buy Pet Button").SetActive(false);
            PetUpgradeButton.SetActive(true);
            PlayerPrefs.SetInt("petExist", 1);
        }
        else
            Debug.Log("No funds");
    }   

    public void SpawnPet2()
    {

        if (gameplayManager.currentCoins >= 40)
        {
            pet2.SetActive(true);
            GameObject.Find("Buy Pet2 Button").SetActive(false); 
            Pet2UpgradeButton.SetActive(true);
            PlayerPrefs.SetInt("pet2Exist", 1);
        }

    }
}
