using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformControler : MonoBehaviour
{
    private MeshRenderer _mesh;
    private BoxCollider _boxCollider;

    void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
        _boxCollider = GetComponent<BoxCollider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Deactivate());
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(Activate());
        }
    }

    private IEnumerator Activate()
    {
        yield return new WaitForSeconds(3);
        _boxCollider.enabled = true;
        _mesh.enabled = true;
    }

    private IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(1);
        _boxCollider.enabled = false;
        _mesh.enabled = false;
    }

}
