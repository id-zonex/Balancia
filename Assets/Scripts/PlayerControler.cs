using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed;
    public GameObject Camera;
    public static int Coins = 0;

    private Vector3 CameraMovemoment;
    private Rigidbody _rigidbody;
    private Vector3 movemoment;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float deltaX = Input.GetAxisRaw("Horizontal") * speed;
        float deltaZ = Input.GetAxisRaw("Vertical") * speed;

        
        movemoment = new Vector3(deltaX * Time.fixedDeltaTime, 0, deltaZ * Time.fixedDeltaTime);
        _rigidbody.AddForce(movemoment);
    }
}
