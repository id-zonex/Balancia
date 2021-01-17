using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 5f;

    public Transform start;
    public Transform end;
    public int velosity = 1;
    void Start()
    {
    }

    void Update()
    { 
        transform.Translate(Vector3.left * velosity * speed * Time.deltaTime);
        if (transform.localPosition.x < start.localPosition.x || transform.localPosition.x > end.localPosition.x)
        {
            velosity = -velosity;
        }
    }


}