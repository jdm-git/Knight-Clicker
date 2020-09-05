using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_BG : MonoBehaviour
{

    public Sprite[] nowy;
    public GameplayManager gameplayManager;
    public ScaleBG ScaleBG;
    int i;
    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.HasKey("BG"))
        {
            this.GetComponent<SpriteRenderer>().sprite = nowy[PlayerPrefs.GetInt("BG")]; 
            ScaleBG.ScaleBackgroundImageFitScreenSize();
        }
        else
        {
            i = 0;

            PlayerPrefs.SetInt("BG", i);
        }
    }

    // Update is called once per frame
    public void BgSwitch()
    {

        if (i == 1)//Zmień wartość przy większej ilości bg w tablicy (Po dotarciu do końca tablicy, przerzuca nas na początek
        {
            i = -1;
            PlayerPrefs.SetInt("BG", i);
        }
        

            i++;
            PlayerPrefs.SetInt("BG", i);
            this.GetComponent<SpriteRenderer>().sprite = nowy[i]; //Zmiana Background po każdym 5 (liczba umowna) stagu 
            ScaleBG.ScaleBackgroundImageFitScreenSize();  //Skalowanie zmienionego BG

        
    }
}
