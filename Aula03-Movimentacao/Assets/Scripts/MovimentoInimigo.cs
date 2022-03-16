using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoInimigo : MonoBehaviour
{
    public Transform[] pontos;
    public int index = 0;
    public float velocidade;

    private void FixedUpdate()
    {
        Vector3 direcao = pontos[index].position - transform.position;

        if (direcao.magnitude <= 0.1f)
        {
            index = (index + 1) % pontos.Length;
        }

        transform.position += direcao.normalized * velocidade * Time.fixedDeltaTime;
    }


}
