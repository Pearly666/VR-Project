using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolMember : MonoBehaviour
{
    public BulletPool pool;

    private void OnBecameInvisible(){
        pool.Kill(this);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            pool.Kill(this);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            pool.Kill(this);
        }
    }
}
