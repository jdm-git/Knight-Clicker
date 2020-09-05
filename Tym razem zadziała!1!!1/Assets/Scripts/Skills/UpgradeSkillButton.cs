using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSkillButton : MonoBehaviour
{
    public SkillUpgradeWindow window;
    public PlayerStats playerStats;
    
  public void Upgrade()
    {
        if (window.skill.damage > 0)
        {
            int damage = window.skill.damage;
            playerStats.HeroAD += damage; // Dodatkowe przeliczniki dla DMG bohatera wraz z wykupieniem skilla
            PlayerPrefs.SetFloat("PlayerAd", playerStats.HeroAD);
            playerStats.unlockedSkills.Add(window.skill.name);
        }
        else if (window.skill.Hp > 0)
        {
            float Hp = window.skill.Hp;
            playerStats.HeroHP += Hp;
            playerStats.unlockedSkills.Add(window.skill.name);



        }
    }
}
