using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Skrypt do obsługi paska HP enemy

public class HealthBar : MonoBehaviour
{
    public Spawner spawner;
    public Slider slider;
    // Start is called before the first frame update

    

    public void Start()
    {
        slider.maxValue = (float)spawner.EnemyCurrentHP;
    }
    public void Zamiana(double maxHP)
    {
        slider.maxValue = (float)maxHP;
    }
    // Update is called once per frame
    void Update()
    {
        slider.value = (float)spawner.EnemyCurrentHP;
    }
}
