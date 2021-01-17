using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatfor_v_2 : MonoBehaviour
{
    public Transform start;
    public Transform middle;
    public Transform end;
    public int upSpeed;
    public int forwardSpeed;

    private int velosity = 1;
    private bool up = true;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (velosity == 1)
        {
            if (transform.localPosition.z > middle.localPosition.z)
            {
                transform.Translate(Vector3.back * forwardSpeed * Time.deltaTime);
            }
            if (transform.localPosition.z < middle.localPosition.z)
            {
                transform.Translate(Vector3.up * upSpeed * Time.deltaTime);
                if (transform.localPosition.y > end.localPosition.y)
                {
                    velosity = -1;
                }

            }
        }
        else
        {
            if (transform.localPosition.y > middle.localPosition.y)
            {
                transform.Translate(Vector3.down * upSpeed * Time.deltaTime);
            }
            if (transform.localPosition.y < middle.localPosition.y)
            {
                transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
                if (transform.localPosition.z > start.localPosition.z)
                {
                    velosity = 1;
                }

            }
        }
    }
    
}
