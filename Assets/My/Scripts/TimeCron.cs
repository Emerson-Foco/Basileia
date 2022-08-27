using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Editar texto UI para cronometro

public class TimeCron : MonoBehaviour
{
    //Variaveis:
    public float startTime = 240;
    public float time;
    public TextMeshProUGUI timerUI;
    public Transform lost;


    // Start is called before the first frame update
    void Start()
    {
        time = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        int minutes = (int)(time / 60); //pegar valor da divisão (minutos)
        int seconds = (int)(time % 60); //pegar resto da divisão (segundos)
        timerUI.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if(time <= 0)
        {
            lost.gameObject.SetActive(true);
        }  
    }
}
