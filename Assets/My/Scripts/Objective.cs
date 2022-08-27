using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    //Variaveis:
    public Transform menuWiner;
    public int teste = 0;

    //detecta colisão
    public void OnTriggerEnter(Collider other)
    {   
        //Objetivo:
        if(other.gameObject.CompareTag("Player")) //Vida
        {
            //Destroy(other.gameObject);
            menuWiner.gameObject.SetActive(true);
        }
    }

}