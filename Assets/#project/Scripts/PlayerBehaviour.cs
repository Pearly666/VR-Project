using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{

void OnTriggerEnter(Collider other)
{
    if(other.CompareTag("Enemy"))
    {
        PlayerDatas.playerLife -= 1;
        Debug.Log(PlayerDatas.playerLife);
        DeadPlayer();
    }
}

void DeadPlayer()
    {
        if(PlayerDatas.playerLife <= 0)
        {
            Debug.Log("you died");
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

}
