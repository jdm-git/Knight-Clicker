using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prestige : MonoBehaviour
{

    public GameObject prestigePanel;

    public void Toogle_Prestige_panel()
    {
        if (prestigePanel.activeSelf )
            prestigePanel.SetActive(false);
        else
            prestigePanel.SetActive(true);


    }

    

}
