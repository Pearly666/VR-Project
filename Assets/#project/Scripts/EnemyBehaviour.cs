using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof (NavMeshAgent))]
public class EnemyBehaviour : MonoBehaviour
{
        [SerializeField]private Transform target;  
        [SerializeField] private int life = 3;

    private NavMeshAgent agent;

    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
    }

    
    void Update()
    {
        agent.SetDestination(target.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player touched by the enemy", gameObject);
        }
        if(other.CompareTag("Bullet"))
        {
            life -= 1;
            KilledByBullet();
        }

    }

    void KilledByBullet()
    {
        if (life == 0) Destroy(gameObject);
        
    }
}
