using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    public Transform spawner;
    bool isSpawning = true;
    public float spawnTime;

    void Start()
    {
        StartCoroutine(spawning());
    }

    IEnumerator spawning()
    {
        while(isSpawning == true)
        {
            yield return new WaitForSeconds(spawnTime);
            Instantiate(enemy, spawner.position, spawner.rotation);
        }
    }
}
