using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Movimento circular ida e volta
public class MovimentoInimigo2 : MonoBehaviour
{
    public Transform[] pontos;
    int index = 0, next = 1;
    public float velocidade;

    private void FixedUpdate()
    {
        Vector3 direcao = pontos[index].position - transform.position;
        transform.position += direcao.normalized * velocidade * Time.fixedDeltaTime;

        if (direcao.magnitude <= 0.1f)
        {
            index += next;

            if ((index >= pontos.Length) || (index < 0))
            {
                next *= -1;
                index += next;
            }
            
        }

        
    }
}
