using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public int fase1 = 1;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Botão Novo Jogo:
    public void NewGame()
    {
        SceneManager.LoadScene(fase1);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    //Botão Sair do jogo:
    public void Exit()
    {
        Application.Quit();
    }
}
