using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainData : MonoBehaviour
{
    public Vector3 checPoint;
    public GameObject Player;

    public void Restart()
    {
        Player.transform.position = checPoint;
    }
}
