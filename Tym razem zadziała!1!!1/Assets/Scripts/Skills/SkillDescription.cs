using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDescription : MonoBehaviour {
    public PassiveSkill skill;
    public SkillUpgradeWindow skillUpgradeWindow;

    public void Display() {
        skillUpgradeWindow.DisplaySkill(skill);
    }
}