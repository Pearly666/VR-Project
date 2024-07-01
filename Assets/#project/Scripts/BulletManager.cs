using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float velocity = 50f;
    private Rigidbody bullet;
    private bool fire = false;
    private PlayerInput playerInput;
    private InputAction inputAction;

    void Awake() 
    {
        playerInput = GetComponent<PlayerInput>();
        inputAction = playerInput.actions["Move"];
    }
    public void OnEnable() 
    {
        inputAction.Enable();
    }
    public void OnDisable() 
    {
        inputAction.Disable();
    }
    void Start()
    {
        bullet = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Firing();
    }

    void Firing()
    {

        transform.Translate(Vector3.right * speed * Time.deltaTime);
        transform.TransformDirection(new Vector3(0, 0, velocity));
    }
}
