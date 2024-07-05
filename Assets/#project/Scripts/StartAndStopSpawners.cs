using UnityEngine;

public class StartAndStopSpawners : MonoBehaviour
{
    public GameObject nextSpawner, stoppedSpawner;

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (stoppedSpawner != null)
            {
                stoppedSpawner.SetActive(false);
            }
            
            if (nextSpawner != null)
            {
                nextSpawner.SetActive(true);
            }
        }
    }
}

