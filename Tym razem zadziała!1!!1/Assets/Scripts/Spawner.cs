using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    #region zmienne
    public double EnemyHP = 40;
    public double EnemyAD = 20;
    public double EnemyCurrentHP;
    public GameObject slider;
    //public GameObject UpgradePetButton;
    public GameObject potwor;
    public GameObject chest;
    
    public GameObject coins;
    public HealthBar bar;
    public GameObject[] monsterPrefab;
    public GameplayManager gameplayManager;
    public int coin = 1;
    public Text TekstLicznikPotworow;
    public Text bossTimer;
    public Text EnemyDMGtext;
    private int licznikTablicy = 0;
    private float licznikPotworow = 1;
    public GameObject miniBossNapis;
    public GameObject epicBossNapis;
    public GameObject fightBossButton;
    public Switch_BG Switch_BG;
    public PlayerStats playerStats;
    

    public Text TekstBossTimer;
    private bool bossON = false;
    private bool czyMoznaZwiekszycLicznikPotworkow = true;
    private float timeLeft;
    private int strefa = 0;

    //public GameObject pet1;
    //public GameObject pet2;

    #endregion

    void Start()
    {
        Button btn = fightBossButton.GetComponent<Button>();
        btn.onClick.AddListener(OdpalBossa);

        if (PlayerPrefs.HasKey("Strefa"))
            strefa = PlayerPrefs.GetInt("Strefa");
        else
            PlayerPrefs.SetInt("Strefa", strefa);
        slider.SetActive(true);

        potwor = (GameObject)Instantiate(monsterPrefab[licznikTablicy]); //Spawn pierwszego enemy

        if (gameplayManager.currentStage == 0) // EnemyHP zwiększa się ze stagem, więc mnożylibyśmy prez 0
        {
            EnemyCurrentHP = EnemyHP;
        }
        else
        {
            EnemyCurrentHP = EnemyHP * gameplayManager.currentStage;
        }

       /* if(PlayerPrefs.HasKey("petExist")) //Sprawdza czy Pet istnieje (jeżeli tak to jest upgrade button, jeśli nie, buy button)
        {
            pet1.SetActive(true);
            GameObject.Find("Buy Pet Button").SetActive(false);
            UpgradePetButton.SetActive(true);
        }*/
    }
    private void Update()
    {


        if(bossON)  // Eventy podczas bossa
        {
            timeLeft -= Time.deltaTime;
            TekstBossTimer.text = Math.Round(timeLeft, 1).ToString(); 

            //Debug.Log(timeLeft);

            if (EnemyCurrentHP <= 0) // Eventy po zabiciu bossa
            {
                bossON = false;
                TekstBossTimer.enabled = false;
                TekstLicznikPotworow.enabled = true;
                czyMoznaZwiekszycLicznikPotworkow = true;
                fightBossButton.SetActive(false);
                Debug.Log("zabito bosa przed czasem");

                if(gameplayManager.currentStage % 5 == 0)//Jeżeli to był boss po 5 stage zmiana BG i strefy   //tu ma byc zmiana strefy - zmienic na %15
                {
                    Switch_BG.BgSwitch();
                    strefa++;
                    PlayerPrefs.SetInt("Strefa", strefa);
                }
                if (gameplayManager.currentStage % 1 == 0) // Co 10 stage po zabiciu bossa wypada chest
                    Instantiate(chest);

            }

            if (timeLeft <= 0) // Eventy jeżeli nie uda nam się zabić bossa na czas
            {
                bossON = false;
                Debug.Log("koniec czasu");

                if(EnemyCurrentHP > 0)
                {
                    Debug.Log("nie udało ci sie zabic bosa na czas");
                    fightBossButton.SetActive(true);
                    licznikPotworow = 9;
                    EnemyCurrentHP = 0;
                    czyMoznaZwiekszycLicznikPotworkow = false;
                    //button / funkcja ktora odpala bosa musi zmienic 'czyMoznaZwiekszycLicznikPotworkow' na true

                }
                else
                {
                    TekstBossTimer.enabled = false;
                    TekstLicznikPotworow.enabled = true;
                    czyMoznaZwiekszycLicznikPotworkow = true;
                    fightBossButton.SetActive(false);
                }

            }
        }




        if (EnemyCurrentHP <= 0) //Eventy po zabiciu pojedynczego enemy
        {
            if (strefa >= 2)
            {   // ograniczenie strefy względem ilości prefabow w tablicy
                strefa = 0;
                PlayerPrefs.SetInt("Strefa", strefa);
            }
            licznikTablicy++;
            if(czyMoznaZwiekszycLicznikPotworkow)
                licznikPotworow++;

            //Debug.Log("stage: " + gameplayManager.currentStage);

            if (licznikPotworow == 11)     
            {
                gameplayManager.UpdateStage();
                licznikPotworow = 1;
                miniBossNapis.SetActive(false);
                epicBossNapis.SetActive(false);
            }

            //Debug.Log(licznikPotworow);
           
            miniBossNapis.SetActive(false);
            epicBossNapis.SetActive(false);


            slider.SetActive(false);
            //if ktory zwieksza HP enemy wraz z stage'em
            if (gameplayManager.currentStage > 1){
                EnemyCurrentHP = EnemyHP * gameplayManager.currentStage;
                bar.Zamiana(EnemyCurrentHP);
            }
            else if (gameplayManager.currentStage == 0){
                EnemyCurrentHP = EnemyHP;
                bar.Zamiana(EnemyCurrentHP);
            }
            else
            {
                EnemyCurrentHP = EnemyHP * 1.5;
                bar.Zamiana(EnemyCurrentHP);
            }
         

            // BOSS EVENT
            if (  gameplayManager.currentStage % 5 == 0 && licznikPotworow == 10) //Duży boss co 5 stage
            {
                bossON = true; timeLeft = 10f;
                TekstLicznikPotworow.enabled = false;
                TekstBossTimer.enabled = true;
                epicBossNapis.SetActive(true);

                EnemyCurrentHP *= 15;
                bar.Zamiana(EnemyCurrentHP);

            }
            else if (licznikPotworow == 10) //Mały boss co każdy stage
            {
                bossON = true; timeLeft = 10f;
                TekstLicznikPotworow.enabled = false;
                TekstBossTimer.enabled = true;
                miniBossNapis.SetActive(true);

                EnemyCurrentHP *= 5;
                bar.Zamiana(EnemyCurrentHP);

            }


            TekstLicznikPotworow.text = licznikPotworow + "/10";
            Destroy(potwor);
            Instantiate(coins);
            slider.SetActive(true);

                    
  

            potwor = (GameObject)Instantiate(monsterPrefab[strefa * 10 + (int)licznikPotworow - 1]); // Spawn każdego kolejnego potwora po zabiciu poprzedniego

            if (GameObject.FindGameObjectsWithTag("Coin").Length > 20) // Automatycznie zbiera coiny jeżeli jest ich przynajmniej 20 na scenie
            {  
                Destroy(GameObject.FindGameObjectWithTag("Coin"));
                gameplayManager.UpdateCoins(coin);
                gameplayManager.UpdateCoins(coin);
                gameplayManager.UpdateCoins(coin);
                gameplayManager.UpdateCoins(coin);
                gameplayManager.UpdateCoins(coin);
            }
        }
    }

    
    public void TakeDamage(double damage)
    {

        //  if (isInvulnerable)
        //  return;
        if (playerStats.ifcrit == true) { 
        EnemyCurrentHP -= damage;
        EnemyDMGtext.enabled = true;
        EnemyDMGtext.text = "-" + Math.Round(damage,2)+ " *Crit*";
        Invoke("DelayIndicator", 0.25f);
           
        }
        else
        {
            EnemyCurrentHP -= damage;
            EnemyDMGtext.enabled = true;
            EnemyDMGtext.text = "-" + Math.Round(damage, 2);
            Invoke("DelayIndicator", 0.25f);
            
        }
    }
    public void DelayIndicator()
    {

        EnemyDMGtext.enabled = false;

    }
    public void OdpalBossa()
    {

        TekstBossTimer.enabled = true;
        TekstLicznikPotworow.enabled = false;
        fightBossButton.SetActive(false);
        czyMoznaZwiekszycLicznikPotworkow = true;
        EnemyCurrentHP = 0;
    }

   /* public void SpawnPet()
    {

        pet1.SetActive(true);
        GameObject.Find("Buy Pet Button").SetActive(false);
        UpgradePetButton.SetActive(true);
        PlayerPrefs.SetInt("petExist", 1);
    }
*/
   /* public void SpawnPet2()
    {

        if (PlayerPrefs.HasKey("petExist")){


            //GameObject.Find("Buy Pet Button").SetActive(false);
            // UpgradePetButton.SetActive(true);
            //PlayerPrefs.SetInt("pet2Exist", 1);
            Debug.Log("Pet2 inc");

        }
    }*/




}