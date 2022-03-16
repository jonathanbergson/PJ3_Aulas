using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRULerp : MonoBehaviour
{
    [Range(0f, 1f)]
    public float t;
    public Transform p1, p2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Função Lerp -> p = p1 + (p2 - p1) * t
        transform.position = Vector3.Lerp(p1.position, p2.position, t);
    }
}
