using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public double EnemyHP = 40;
    public double EnemyAD = 20;
    public double EnemyCurrentHP;
    public GameObject slider;
    public GameObject UpgradePetButton;
    public GameObject potwor;
    public GameObject pet;
    public GameObject coins;
    public HealthBar bar;
    public GameObject[] monsterPrefab;
    public GameplayManager gameplayManager;
    public int coin = 1;
    public Text TekstLicznikPotworow;
    public Text EnemyDMGtext;
    private int licznikTablicy = 0;
    private float licznikPotworow = 1;
    public GameObject miniBossNapis;
    public GameObject epicBossNapis;
    public GameObject fightBossButton;

    

    private bool bossON = false;
    private bool czyMoznaZwiekszycLicznikPotworkow = true;
    private float timeLeft;


    void Start()
    {
        Button btn = fightBossButton.GetComponent<Button>();
        btn.onClick.AddListener(odpalBossa);


        //PlayerPrefs.DeleteAll();
        slider.SetActive(true);
         potwor = (GameObject)Instantiate(monsterPrefab[licznikTablicy]);
        if (gameplayManager.currentStage == 0)
        {
            EnemyCurrentHP = EnemyHP;
        }
        else
        {
            EnemyCurrentHP = EnemyHP * gameplayManager.currentStage;
        }
    }
    private void Update()
    {


        if(bossON)  //
        {
            timeLeft -= Time.deltaTime;

            Debug.Log(timeLeft);

            if (EnemyCurrentHP <= 0)
                bossON = false;

            if (timeLeft <= 0)
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
                    czyMoznaZwiekszycLicznikPotworkow = true;
                    fightBossButton.SetActive(false);
                }

            }
        }




        if (EnemyCurrentHP <= 0)
        {

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

            Debug.Log(licznikPotworow);
           
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
            if (  gameplayManager.currentStage % 5 == 0 && licznikPotworow == 10)
            {
                bossON = true; timeLeft = 10f;
                EnemyCurrentHP *= 15;
                bar.Zamiana(EnemyCurrentHP);
                epicBossNapis.SetActive(true);

            }
            else if (licznikPotworow == 10)
            {
                bossON = true; timeLeft = 10f;
                EnemyCurrentHP *= 5;
                bar.Zamiana(EnemyCurrentHP);
                miniBossNapis.SetActive(true);

            }


            TekstLicznikPotworow.text = licznikPotworow + "/10";
            Destroy(potwor);
            Instantiate(coins);
            slider.SetActive(true);

                    
                                                                            // naprawic trza
            // zmieniłem >3 na >2, ogarnąć czy sie nie buguje coś
            if (licznikTablicy > 3)
                licznikTablicy = 0;

            potwor = (GameObject)Instantiate(monsterPrefab[licznikTablicy]);




            if (GameObject.FindGameObjectsWithTag("Coin").Length > 20)
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

    public void SpawnPet()
    {

        pet.SetActive(true);
        GameObject.Find("Buy Pet Button").SetActive(false);
        UpgradePetButton.SetActive(true);
    }

    public void TakeDamage(double damage)
    {

        //  if (isInvulnerable)
        //  return;
        EnemyCurrentHP -= damage;
        //hi.SetHealth();
        EnemyDMGtext.enabled = true;
        EnemyDMGtext.text = "-" + damage;
        Invoke("DelayIndicator", 0.25f);
}
    public void DelayIndicator()
    {

        EnemyDMGtext.enabled = false;

    }
    public void odpalBossa()
    {
        czyMoznaZwiekszycLicznikPotworkow = true;
        EnemyCurrentHP = 0;
    }






}