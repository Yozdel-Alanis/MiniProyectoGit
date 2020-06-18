using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
    GameManager gameManager = FindObjectOfType<GameManager>();

    gameManager.GameOver();

        SceneManager.LoadScene(0);
    }
}
