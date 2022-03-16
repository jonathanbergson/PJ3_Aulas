using UnityEngine;
public class MRU : MonoBehaviour
{
    [Range(0f, 1f)]
    public float t;
    public Vector3 v;
    public Transform p1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // p = p0 + v * t
        // onde p0 é o ponto, v = vetor (direção) e t = escalar
        transform.position = p1.position + v * t;
    }
}

