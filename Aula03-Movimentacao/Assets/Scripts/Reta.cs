using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reta : MonoBehaviour
{
    // y = ax + b
    public float a, b, x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Equação geral da reta
        float y = a * x + b;
        Vector3 p = new Vector3(x, y, 0);
        transform.position = p;
    }
}
