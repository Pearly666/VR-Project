using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondGunBoosterMovement : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float orbitSpeed = 10.0f;
    [SerializeField] private float orbitDistance = 1.0f;
    private float angle = 0.0f;

    void Update()
    {
        if (target != null)
        {
            angle += orbitSpeed * Time.deltaTime;
            float radians = angle * Mathf.Deg2Rad;
            float x = Mathf.Cos(radians) * orbitDistance;
            float z = Mathf.Sin(radians) * orbitDistance;
            transform.position = new Vector3(target.position.x + x, transform.position.y, target.position.z + z);
            transform.LookAt(target);
        }
    }
}
