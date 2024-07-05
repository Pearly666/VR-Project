using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGunBooster : MonoBehaviour
{    
    

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            Debug.Log("Booster Activated", gameObject);
            PlayerDatas.secondGunBoosterActivated = true;
            Debug.Log("Parent? " + transform.parent.gameObject);
            Destroy(transform.parent.gameObject);
        }
    }
}
