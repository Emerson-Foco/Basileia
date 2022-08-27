using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVL : MonoBehaviour
{
    //Variáveis:
    public int lvl = 1;
    public int sceneLvl = 1;

    //Carregar Level:
    public void LoadLevel()
    {
        SceneManager.LoadScene(sceneLvl);
    }
}
