using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BoostManager : MonoBehaviour
{
    private bool doubleGunBoost = false;
    private int score = PlayerDatas.playerScore;
    public UnityEvent<int> onScoreBoost;

    void Start()
    {
        onScoreBoost = new UnityEvent<int>();
        onScoreBoost.AddListener(EnableDoubleGun);
    }

    void Update()
    {
        if(score == 10) onScoreBoost.Invoke(score);
    }
    void EnableDoubleGun(int score)
    {
        GameObject.FindGameObjectWithTag("LeftGun").GetComponent<BulletFactory>().canShoot = true;
    }
}
