using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBulletPoolMember : MonoBehaviour
{
    public SecondBulletPool pool;

    private void OnBecameInvisible(){
        pool.Kill(this);
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enzo aime mange du popo");
        if(other.CompareTag("Enemy"))
        {
            pool.Kill(this);
        }
    }
}
