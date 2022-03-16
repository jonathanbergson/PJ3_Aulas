using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MRUTwoPoints : MonoBehaviour
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
        Vector3 v = (p2.position - p1.position);
        transform.position = p1.position + v * t;
      
    }
}
