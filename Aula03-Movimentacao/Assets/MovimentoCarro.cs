using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCarro : MonoBehaviour
{
    public WheelCollider[] rodas;
    public Transform[] rodaShape;
    public float torque = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicao;
        Quaternion rotacao;

        float t = Input.GetAxis("Vertical") * torque;

        for (int i = 0; i < rodas.Length; i++)
        {
            rodas[i].motorTorque = t;

            rodas[i].GetWorldPose(out posicao, out rotacao);
            rodaShape[i].position = posicao;
            rodaShape[i].rotation = rotacao;
            
        }
    }
}
