﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UpgradeBase : MonoBehaviour
{
    public Spawner ps;
    public void UpdateStats()
    {
        ps.AD *= 1.3f;
    }
}
