using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    public Transform target;
    public float speed;
    Vector3 dir;

    private void FixedUpdate()
    {
        if (target.hasChanged)
        {
            dir = target.position - transform.position;
        }
        
        transform.position += dir * speed * Time.fixedDeltaTime;

    }
}
