using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    public float tempoInicial = 50f;
    private float tempoAtual;
    private bool cronometroAtivo = false;
    [SerializeField]private Text textoCronometro;

    void Start()
    {
        textoCronometro = GetComponent<Text>();
        tempoAtual = tempoInicial;
        AtualizarTextoCronometro();
        textoCronometro.text = "00:00:00";
    }

    void Update()
    {
        if (cronometroAtivo)
        {
            tempoAtual -= Time.deltaTime;

            if (tempoAtual <= 0)
            {
                tempoAtual = 0;
                cronometroAtivo = false;
            }

            AtualizarTextoCronometro();
        }
    }

    public void IniciarCronometro()
    {
        cronometroAtivo = true;
    }

    public void PararCronometro()
    {
        cronometroAtivo = false;
    }

    void AtualizarTextoCronometro()
    {
        int minutos = Mathf.FloorToInt(tempoAtual / 60);
        int segundos = Mathf.FloorToInt(tempoAtual % 60);

        textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
