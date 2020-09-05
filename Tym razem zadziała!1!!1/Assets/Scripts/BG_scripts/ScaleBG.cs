using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBG : MonoBehaviour
{

    public GameObject backgroundImage;
  //  public GameObject backgroundImageSecond;
    //public GameObject backgroundImageThird;
    //public GameObject backgroundImageFourth;
    public Camera mainCam;
    public GameplayManager gameplayManager;
    public Sprite[] spritearray;
    // Start is called before the first frame update
    void Start()
    {
        ScaleBackgroundImageFitScreenSize();
    }

    public void ScaleBackgroundImageFitScreenSize()
    {
        //Step 1
        Vector2 deviceScreenResolution = new Vector2(Screen.width, Screen.height);


        float srcHeight = Screen.height;
        float srcWidth = Screen.width;

        float DEVICE_SCREEN_ASPECT = srcWidth / srcHeight;


        //Step 2
        mainCam.aspect = DEVICE_SCREEN_ASPECT;
        //Step 3
        float camHeight = 100.0f * mainCam.orthographicSize * 2.0f;
        float camWidth = camHeight * DEVICE_SCREEN_ASPECT;


        SpriteRenderer backgroundImageSR = backgroundImage.GetComponent<SpriteRenderer>();
        float bgImgH = backgroundImageSR.sprite.rect.height;
        float bgImgW = backgroundImageSR.sprite.rect.width;



        float bgImg_scale_ratio_Height = camHeight / bgImgH;
        float bgImg_scale_ratio_Widht = camWidth / bgImgW;

        backgroundImage.transform.localScale = new Vector3(bgImg_scale_ratio_Widht, bgImg_scale_ratio_Height, 1);
    }
    public void Update()
    {
        
    }
}