using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Na razie nie używane (?)

public class Example : MonoBehaviour
{

    public void setQualityByIndex(int QualityIndex)
    {
        Debug.Log("QIndex " + QualityIndex);
        QualitySettings.SetQualityLevel(QualityIndex);
    }
}