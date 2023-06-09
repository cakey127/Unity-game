using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ENDGAMEMENU2 : MonoBehaviour
{
    public void NEXTLEVEL ()
    {
       SceneManager.LoadScene("Main_Menu");
    }

    public void MAINMENU ()
    {
       SceneManager.LoadScene("Main_Menu");
    }

    public void RESTART ()
    {
       SceneManager.LoadScene("Level 1");
    }
}
