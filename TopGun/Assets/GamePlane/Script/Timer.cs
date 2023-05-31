using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Text timeLevel_txt;
    [SerializeField] private float tempoMaximo = 50;
    private float timelevel;
    public static bool stopTime;
    public GameObject aviao;

    private void Start() 
    {
        stopTime = false;   
    }

    private void Update() {
        if (stopTime == false)
        {
            timelevel = timelevel + Time.deltaTime;
            timeLevel_txt.text = timelevel.ToString("0");

            if (timelevel >= tempoMaximo)
            {
               aviao.SetActive(false);

            }
        }
    }

}
