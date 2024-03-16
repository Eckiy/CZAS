using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pokoj1enter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(2, LoadSceneMode.Single);
        }    
    }
}
