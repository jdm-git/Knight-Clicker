using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHero : MonoBehaviour
{
    public PlayerStats stats;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = (float)stats.HeroHP;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = (float)stats.HeroCurrentHP;
        slider.maxValue = (float)stats.HeroHP;
    }
}
