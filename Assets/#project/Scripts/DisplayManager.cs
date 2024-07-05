using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DisplayManager: MonoBehaviour
{
    public TMP_Text scoreText;
    int lastScore;


    public void UpdateScore(int value)
    {
        if(0 != value)
        {
            scoreText.SetText($"Score: {value}");
        }
    }
}
