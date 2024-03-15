using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour
{
    [SerializeField] private GameObject BiurkoPanel;
    private bool playerIsClose;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsClose == true)
        {
            BiurkoPanel.SetActive(true);
        }
        else
        {
            BiurkoPanel.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
}
