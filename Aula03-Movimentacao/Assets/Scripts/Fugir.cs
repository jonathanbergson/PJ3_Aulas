using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fugir : MonoBehaviour
{
    public Transform target;
    public float speed;
    Vector3 dir;

    private void FixedUpdate()
    {
        if (target.hasChanged)
        {
            dir = (transform.position - target.position).normalized;
        }

        transform.position += dir * speed * Time.fixedDeltaTime;

    }

}
