using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillUpgradeWindow : MonoBehaviour {
    public Text nameText;
    public Text descText;
    public Text damageValue;
    public Text cost;
    public Button upgradeButton;
    public PlayerStats playerstats;
    public PassiveSkill skill;

    public void DisplaySkill(PassiveSkill skill) {
        this.skill = skill;
        nameText.text = "Name: " + skill.name;
        descText.text = "Skill Description: " + skill.description;
        if (skill.damage > 0)
            damageValue.text = skill.damage.ToString();
        else
            damageValue.text = skill.Hp.ToString();
        cost.text = "Skill Cost: " + skill.pointCost;
        upgradeButton.interactable = !playerstats.unlockedSkills.Contains(skill.name);
    }
}