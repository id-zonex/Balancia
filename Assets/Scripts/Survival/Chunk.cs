using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chunk : MonoBehaviour
{
    public Transform EndPos;
    public Transform MidlePos;
    public Transform StartPos;

    public Vector3 NextRotation;

    public void SetRotation(Vector3 Rotation)
    {
        this.transform.rotation = Quaternion.Euler(Rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Destroy");
        Destroy(gameObject);
    }

}
