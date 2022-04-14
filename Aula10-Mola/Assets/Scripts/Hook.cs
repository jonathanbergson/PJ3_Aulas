using UnityEngine;

public class Hook : MonoBehaviour
{
    public float k;
    public float L;
    public Transform refPoint;
    
    Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // f = k(|d| * L) * d.Normalized
    void Update()
    {
        Vector3 d = refPoint.position - transform.position;
        Vector3 f = k * (d.magnitude * L) * d.normalized;

        _rb.AddForce(f);
    }
}
