using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CicloTeste : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Entrei no Awake.");
    }

    private void OnEnable()
    {
        Debug.Log("Entrei no OnEnable.");
    }

    void Start()
    {
        Debug.Log("Entrei no Start.");
    }


    private void FixedUpdate()
    {
        Debug.Log("Entrei no FixedUpdate.");
    }

    void Update()
    {
        Debug.Log("Entrei no Update.");
    }

    private void LateUpdate()
    {
        Debug.Log("Entrei no LateUpdate.");
    }

    private void OnDisable()
    {
        Debug.Log("Entrei no OnDisable.");
    }

    private void OnDestroy()
    {
        Debug.Log("Entrei no OnDestroy.");
    }

}
