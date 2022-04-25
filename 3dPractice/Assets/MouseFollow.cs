using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 30.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tiltAroundZ = Input.GetAxis("Mouse X") * tiltAngle * -4;
        float tiltAroundX = Input.GetAxis("Mouse Y") * tiltAngle * 4;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
