using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdaVolta : MonoBehaviour
{
    public Transform p1, p2;
    public float speed;
    float t;

    private void FixedUpdate()
    {
        t = Mathf.PingPong(Time.time * speed, 1.0f);
        transform.position = Vector3.Lerp(p1.position, p2.position, t);
    }

}
