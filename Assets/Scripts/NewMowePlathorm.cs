using System.Collections.Generic;
using UnityEngine;

public class NewMowePlathorm : MonoBehaviour
{

    [SerializeField] Transform[] positions;
    [SerializeField] Transform platform;
    public float speed;


    private int curentPosition = 0;
    private int velosity = 1;


    void FixedUpdate()
    {
        curentPosition = Mathf.Clamp(curentPosition, 0, positions.Length - 1);
        platform.position = Vector3.MoveTowards(platform.position, positions[curentPosition].position, speed * Time.deltaTime);

        if (platform.position == positions[curentPosition].position)
        {
            if (velosity == -1)
            {
                curentPosition -= 1;
                print("-");
            }
            else
            {
                print("+");
                curentPosition += 1;
            }
            
            if (curentPosition >= positions.Length  || curentPosition <= 0)
            {
                print("v");
                velosity = -velosity;
            }

        }
    }
}
