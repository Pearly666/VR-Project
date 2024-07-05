using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    public Transform spawner;
    bool isSpawning = true;
    public float spawnTime;

    void Start()
    {
        StartCoroutine(spawning());
    }

    void Update()
    {

    }
    IEnumerator spawning()
    {
        while(isSpawning == true)
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(zombie, spawner.position, spawner.rotation);
        }
    }
}
