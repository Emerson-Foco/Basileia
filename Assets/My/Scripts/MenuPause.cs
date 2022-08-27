using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    //Variaveis:
    public int sceneMenuInicial = 0;
    public int sceneCurrent = 1;
    public int sceneNextLevel = 2;
    public Transform menuPause;
    public Transform menuLost;
    public Transform menuWiner;

    void Start()
    {
        Time.timeScale = 1;
    }

    //Ativar/Desativar Pausa:
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(menuPause.gameObject.activeSelf)
            {
                Time.timeScale = 1; //ativa o jogo
                menuPause.gameObject.SetActive(false); //desativa menu
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                Time.timeScale = 0; //parar o jogo
                menuPause.gameObject.SetActive(true); //ativa menu
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }

        //Detectar Menu Lost ativo:
        if(menuLost.gameObject.activeSelf)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        //Detectar Menu Winer ativo:
        if(menuWiner.gameObject.activeSelf)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    
    //Botão Reiniciar:
    public void Restart()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(sceneCurrent);
    }

    //Botão Continuar:
    public void Continue()
    {
        if(menuPause.gameObject.activeSelf)
        {
            Time.timeScale = 1;
            menuPause.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    //Botão Menu Inicial:
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneMenuInicial);
    }

    //Botão Próximo Nível:
    public void NextLevel()
    {
        Time.timeScale = 1;
        menuWiner.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(sceneNextLevel);
    }

    //Botão Sair:
    public void Sair()
    {
        Application.Quit();
    }
}
