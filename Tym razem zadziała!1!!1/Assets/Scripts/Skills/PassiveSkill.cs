using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Passive Skill", menuName = "Passive Skill")]
public class PassiveSkill : ScriptableObject
{
    public new string name;
    public string description;
    public float Hp;
    public int pointCost;
    public int damage;
}
