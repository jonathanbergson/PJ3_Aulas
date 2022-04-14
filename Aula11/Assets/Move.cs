using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody _rb;
    public float speed = 5.0f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _rb.MovePosition(transform.position + dir * speed * Time.deltaTime);
        }
    }
}
