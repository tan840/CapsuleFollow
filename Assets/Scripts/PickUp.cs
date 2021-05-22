using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Powerups
/// </summary>
public class PickUp : MonoBehaviour
{
    GameManager gameManager;
    private void Start()
    {
        gameManager = GameManager.instance;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            gameManager.UI_TextUpdate();

        }
    }
  
}
