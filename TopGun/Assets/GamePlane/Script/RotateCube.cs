using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float velocidadeCubo = 1.5f;
    private float novaVelocidade = 10.0f;

    void Start()
    {
        Debug.Log("Meu jogo");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( velocidadeCubo * Time.deltaTime, 0, 0);
        Debug.Log("velocidade é" + velocidadeCubo);

    }
    //Raissa
    //Vitor Da u pino
    //Enzo
    //Joauin Tavares
    //Leone Carpine
    //Lívia Silveira
    //Karoline Vieira
    //Adrian Fantozi
    //Samuela Sodre
    // Thiago Nicola Cajuela Garcia
}
