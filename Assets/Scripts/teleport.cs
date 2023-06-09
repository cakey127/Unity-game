using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour
{
    public Transform player;
    public GameObject playerg;
 
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
        
        
    }
    
}