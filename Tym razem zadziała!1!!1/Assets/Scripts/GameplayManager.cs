using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{

    public Spawner spawner;
    public Text textCoins;
    public Text textStage;
    public Text WalutaPremText;
    private int WalutaPrem = 0;
    public int currentCoins;
    public int currentStage;

    public void Start()
    {

        if (PlayerPrefs.GetInt("Stage") >= 2)                   
        {
            PlayerPrefs.SetInt("Stage", PlayerPrefs.GetInt("Stage"));
        }
        else
        {
            PlayerPrefs.SetInt("Stage", currentStage);
        }
        PlayerPrefs.GetInt("Stage");
        currentStage = PlayerPrefs.GetInt("Stage");
        textStage.text = "Stage : " + currentStage.ToString();
        PlayerPrefs.GetInt("Monety");
        currentCoins = PlayerPrefs.GetInt("Monety");
        textCoins.text = "Coins : " + currentCoins.ToString();

        if (PlayerPrefs.HasKey("WalutaPrem"))
            WalutaPrem = PlayerPrefs.GetInt("WalutaPrem");
        else
            PlayerPrefs.SetInt("WalutaPrem", 0);

        WalutaPremText.text = "Ilosc walutki premium : " + PlayerPrefs.GetInt("WalutaPrem");
    }


    public void UpdateCoins(int coins) // Metoda do update ilości coinów
    {
        currentCoins += coins;
        PlayerPrefs.SetInt("Monety", currentCoins);
        textCoins.text = "Coins : " + currentCoins.ToString();

    }
    public void UpdateStage() // Metoda do update current stage
    {

        currentStage++;
        PlayerPrefs.SetInt("Stage", currentStage);
        textStage.text = "Stage : " + currentStage.ToString();

    }

    public void PlayerPrefsDelete() //Metoda do czyszczenia PlayerPrefs przy zdobyciu prestiżu
    {

        WalutaPrem++;
        PlayerPrefs.SetInt("WalutaPrem", WalutaPrem);

        //PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("Strefa");
        PlayerPrefs.DeleteKey("Monety");
        PlayerPrefs.DeleteKey("Stage");
        PlayerPrefs.DeleteKey("BG");
        PlayerPrefs.DeleteKey("petExist");
        PlayerPrefs.DeleteKey("pet2Exist");
        PlayerPrefs.DeleteKey("Koszt");
        PlayerPrefs.DeleteKey("Pet1UpgradeCost");
        PlayerPrefs.DeleteKey("Pet2UpgradeCost");
        PlayerPrefs.DeleteKey("PlayerAd");
        PlayerPrefs.DeleteKey("PlayerHp");
        PlayerPrefs.DeleteKey("PetAd");
        PlayerPrefs.DeleteKey("Pet2Ad");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
