using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour
{
    public Transform player;
    public GameObject playerg;

   void OnTriggerEnter(Collider other)
    {
        Debug.Log ("END");
        SceneManager.LoadScene("ENDGAMESCREEN", LoadSceneMode.Single);
    }
}
