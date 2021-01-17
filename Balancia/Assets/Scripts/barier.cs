using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barier : MonoBehaviour
{
    public mainData mainData;

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Player")
        {
            mainData.Restart();
        }
    }

}
