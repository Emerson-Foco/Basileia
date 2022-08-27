using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealtPlayer : MonoBehaviour
{
    //Variaveis:
    public float maxHealt = 10f; //valor maximo da vida
    public float healt = 10f; //valor atual da vida
    public Image lifeBar; //barra de vida
    public Transform lost; //menu lost
    public ParticleSystem damager; //Particulas para quando sofrer dano
    public ParticleSystem healting; //Particulas para quando se curar
    public AudioSource damagerAud; //Audio para quando sofrer dano
    public AudioSource healtingAud; //Audio para quando se curar
public Transform menuWiner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HealtBar();
    }

    //Calcula vida
    public void HealtBar()
    {
        lifeBar.fillAmount = healt / maxHealt; //calcular valor do fill da imagem
        
        if(healt <= 0)
        {
            Time.timeScale = 0;
            lost.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    //detecta colisão de particulas
    public void OnParticleCollision(GameObject other)
    {
        if(other.gameObject.layer == 6)
        {
            damager.Play();
            damagerAud.Play();
            healt -= 1;
        }    
    }

    //detecta colisão
    public void OnTriggerEnter(Collider other)
    {   
        //Causa dano:
        if(other.gameObject.CompareTag("fire")) //Fogo
        {
            damager.Play();
            damagerAud.Play();
            healt -= 1;
            Destroy(other.gameObject);
        }

        //Cura:
        if(other.gameObject.CompareTag("healt")) //Vida
        {
            healt = maxHealt;
            Destroy(other.gameObject);
            healting.Play();
            healtingAud.Play();
        }
    }

}
