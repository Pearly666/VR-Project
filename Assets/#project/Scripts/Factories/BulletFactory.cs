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
        //StartCoroutine(Create());
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
        if(ctx.phase == InputActionPhase.Performed)
        {
            StartCoroutine(Create());
        }
    }
}
