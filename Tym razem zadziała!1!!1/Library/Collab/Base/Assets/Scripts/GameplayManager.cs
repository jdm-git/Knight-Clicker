using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameplayManager : MonoBehaviour
{
    
    public Spawner licznik;
    public Text text;
    public Text stage;
    public int currentScore;
    public int currentStage;
    public void Awake()
    {
        PlayerPrefs.DeleteAll();
    }
    public void Start()
    {
       
        if(PlayerPrefs.GetInt("Stage") >= 2)                   //top 10 kodow programisty <33333
        {
            PlayerPrefs.SetInt("Stage", PlayerPrefs.GetInt("Stage"));
        }
        else
        {
            PlayerPrefs.SetInt("Stage", currentStage);
        }
        PlayerPrefs.GetInt("Stage");
        currentStage = PlayerPrefs.GetInt("Stage");
        stage.text = "Stage : " + currentStage.ToString();
        PlayerPrefs.GetInt("Monety");
        currentScore = PlayerPrefs.GetInt("Monety");
        text.text = "Coins : " + currentScore.ToString();
    }

    
    public void UpdateScore(int score)
    {
        currentScore += score;
        PlayerPrefs.SetInt("Monety", currentScore);
        text.text = "Coins : " + currentScore.ToString();
        
    }
    public void UpdateStage()
    {
        
            currentStage++;
            PlayerPrefs.SetInt("Stage", currentStage);
            stage.text = "Stage : " + currentStage.ToString();
        
    }

    
}
