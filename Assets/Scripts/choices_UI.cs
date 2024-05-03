using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class choices_UI : MonoBehaviour
{
    public GameObject choices_buttons;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            choices_buttons.SetActive(true);
        }
    }

    
    
}
