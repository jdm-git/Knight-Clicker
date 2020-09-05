using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_BG : MonoBehaviour
{

    public Sprite[] nowy;
    public GameplayManager gameplayManager;
    public ScaleBG ScaleBG;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (gameplayManager.currentStage % 2 == 0)
        {
            
            this.GetComponent<SpriteRenderer>().sprite = nowy[i];
            ScaleBG.ScaleBackgroundImageFitScreenSize();
            
        }
        else
        {

        }
        
    }
}
