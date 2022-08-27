using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Variaveis:
    public int sceneCurrent = 1;
    public GameObject FPSControll;
    public float life;
    
    // Start is called before the first frame update
    void Start()
    {
        //life = FPSControll.GetComponent<HealtPlayer>().healt;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        life = FPSControll.GetComponent<HealtPlayer>().healt;
        if(life <= 0)
        {
            SceneManager.LoadScene(sceneCurrent);
        }
        */
    }
}
