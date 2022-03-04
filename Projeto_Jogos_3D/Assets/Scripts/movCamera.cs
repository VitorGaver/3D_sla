using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movCamera : MonoBehaviour
{
    public GameObject bola;
    Vector3 posicaoInicial;
    Vector3 posicaoAtual;

    void Start()
    {
        posicaoInicial = bola.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        posicaoAtual = bola.transform.position;
        transform.position = transform.position + (posicaoAtual - posicaoInicial);
        posicaoInicial = bola.transform.position;
    }
}
