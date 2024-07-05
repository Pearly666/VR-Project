using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BoostManager : MonoBehaviour
{
    [SerializeField] GameObject secondGun;
    void Update()
    {
        if(secondGun == null)
        {
            if( secondGun.activeSelf == false && PlayerDatas.playerScore >= PlayerDatas.killForSecondHandBooster)
            {
                secondGun.SetActive(true);
            }
        }
    }

}