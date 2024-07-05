using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameReload : MonoBehaviour
{
    public string Game;
    public void ChangeScene()
    {
        SceneManager.LoadScene(Game);
    }


}
