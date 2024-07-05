using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BoostManager : MonoBehaviour
{
    private bool doubleGunBoost = false;
    private int score = PlayerDatas.playerScore;
    public UnityEvent<int> onScoreBoost;

    void Start()
    {
    }

    void Update()
    {
    }
}
