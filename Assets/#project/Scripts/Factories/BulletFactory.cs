using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFactory : MonoBehaviour
{
    [SerializeField] float cooldown = 0.5f;
    [SerializeField] GameObject prefab;
    [SerializeField]private BulletPool pool;
    [SerializeField] private Transform launchPoint;
    // Start is called before the first frame update
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
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        while (true)
        {
            if (pool != null)
            {
                pool.Spawn(launchPoint.position + Vector3.right, Quaternion.identity);
            }
            else
            {
                Instantiate(prefab, launchPoint.position + Vector3.right, Quaternion.identity);
            }
            yield return new WaitForSeconds(cooldown);
        }
    }
}
