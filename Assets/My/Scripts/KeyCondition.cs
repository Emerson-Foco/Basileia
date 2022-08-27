using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCondition : MonoBehaviour
{
    //Variáveis:
    public GameObject objetivo;
    public Transform obj1;
    public Transform obj2;
    public bool update = false;
    
    public void Awake()
    {
        objetivo = GameObject.Find("ObjectivePivo");
        obj1 = GameObject.Find("TxtObjetivo1").GetComponent<Transform>();
        obj2 = GameObject.Find("TxtObjetivo2").GetComponent<Transform>();
    }
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Primeiro update:
        if (update == false)
        {
            objetivo.SetActive(false);
            obj2.gameObject.SetActive(false);
            update = true;
        }
    }

    //Verificar colisão com player:
    public void OnTriggerEnter(Collider other)
    {
        //Condição para liberar o próximo objetivo:
        if(other.CompareTag("Player"))
        {
            obj1.gameObject.SetActive(false);
            obj2.gameObject.SetActive(true);
            objetivo.SetActive(true);
            Destroy(gameObject);
        }
    }
}
