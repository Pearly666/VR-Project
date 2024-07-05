using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletFactory : MonoBehaviour
{
    [SerializeField] float cooldown = 0.5f;
    [SerializeField] GameObject prefab;
    [SerializeField]private BulletPool pool;
    [SerializeField] private Transform launchPoint;
    [SerializeField] public Boolean canShoot = true;
    [SerializeField] public float killForBooster = 10;
    void Start()
    {

        if (pool == null)
        {
            pool = GetComponent<BulletPool>();
        }
        if (pool == null)
        {
            pool = FindObjectOfType<BulletPool>();
        }
    }

    void Update()
    {
        if(!canShoot && PlayerDatas.playerScore >= killForBooster) canShoot = true;
    }

    private IEnumerator Create()
    {
            if (pool != null)
            {
                pool.Spawn(launchPoint.position,launchPoint.rotation);
            }
            else
            {
                Instantiate(prefab, launchPoint.position, launchPoint.rotation);
            }
            yield return new WaitForSeconds(cooldown);
    }

    public void Shoot(InputAction.CallbackContext  ctx)
    {
        if(canShoot)
        {
            if(ctx.phase == InputActionPhase.Performed)
            {
                StartCoroutine(Create());
            }
        }
    }
}
