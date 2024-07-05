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
            Debug.Log("secondGun == null: " + secondGun == null);
        if(secondGun != null)
        {
            //Debug.Log("in the if: " + (secondGun.activeSelf == false && PlayerDatas.playerScore >= PlayerDatas.killForSecondHandBooste));
            if( !secondGun.activeSelf && PlayerDatas.playerScore >= PlayerDatas.killForSecondHandBooster)
            {
                secondGun.SetActive(true);
            }
        }
    }

}