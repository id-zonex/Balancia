using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekPointControler : MonoBehaviour
{
    public mainData mainData;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            mainData.checPoint = transform.position;
        }
    }
}
