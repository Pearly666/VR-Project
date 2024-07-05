using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class BoostManager : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float orbitSpeed = 10.0f;
    [SerializeField] private float orbitDistance = 1.0f;
    private float angle = 0.0f;

    void Update()
    {
        if (target != null)
        {
            angle += orbitSpeed * Time.deltaTime; // Increase the angle over time
            float radians = angle * Mathf.Deg2Rad; // Convert angle to radians

            // Calculate the new position
            float x = Mathf.Cos(radians) * orbitDistance;
            float z = Mathf.Sin(radians) * orbitDistance;
            transform.position = new Vector3(target.position.x + x, transform.position.y, target.position.z + z);

            // Optionally, make the object face the target
            transform.LookAt(target);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            Debug.Log("Booster Activated", gameObject);
            PlayerDatas.secondGunBoosterActivated = true;
        }
    }
}