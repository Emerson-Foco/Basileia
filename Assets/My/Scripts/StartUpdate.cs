using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpdate : MonoBehaviour
{
    public bool update = false;
    void Update()
    {
        if(update == false)
        {
            Time.timeScale = 1;
            update = true;
        }
    }
}
