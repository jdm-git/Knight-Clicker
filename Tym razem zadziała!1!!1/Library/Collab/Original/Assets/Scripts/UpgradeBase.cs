using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UpgradeBase : MonoBehaviour
{
    public PlayerStats ps;
    void UpdateStats()
    {
        ps.AD *= 1.3f;
}

    }