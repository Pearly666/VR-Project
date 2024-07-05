using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof (NavMeshAgent))]
public class EnemyBehaviour : MonoBehaviour
{
    public UnityEvent<int> onKilled;
    [SerializeField] private Transform target;  
    [SerializeField] private int life = 3;

    private NavMeshAgent agent;

    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
        DisplayManager displayManager = FindObjectOfType<DisplayManager>();
        onKilled.AddListener(displayManager.UpdateScore);
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

    public void KilledByBullet()
    {
        if (life == 0)
        {
        PlayerDatas.playerScore++;
        onKilled?.Invoke(PlayerDatas.playerScore);
        Destroy(gameObject);
        }
    }
}
