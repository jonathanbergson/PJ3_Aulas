using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ida : MonoBehaviour
{
    public Transform p1, p2;
    public float speed;
    float t;

    private void FixedUpdate()
    {
        t = ((t + Time.fixedDeltaTime * speed) % 1.0f);
        transform.position = Vector3.Lerp(p1.position, p2.position, t);

        if(t == 1.0)
        {
            transform.position = p1.position;
        }
    }



}
