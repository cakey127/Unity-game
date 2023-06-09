using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENDGAMEMENU : MonoBehaviour
{
    public void NEXTLEVEL ()
    {
       SceneManager.LoadScene("Level 1");
    }

    public void MAINMENU ()
    {
       SceneManager.LoadScene("Main_Menu");
    }

    public void RESTART ()
    {
       SceneManager.LoadScene("Tutorial");
    }
}
