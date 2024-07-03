using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
[SerializeField] private float playerLife = 5;

void OnTriggerEnter(Collider other)
{
    if(other.CompareTag("Enemy"))
    {
        playerLife -= 1;
        Debug.Log(playerLife);
        DeadPlayer();
    }
}

void DeadPlayer()
    {
        if(playerLife <= 0)
        {
            Debug.Log("you died");
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

}
