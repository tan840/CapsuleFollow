using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Handles the UI and game State
/// </summary>
public class GameManager : MonoBehaviour
{
    public TMP_Text countGem;
    int gemCounter = 0;

    public TMP_Text playerText;
    public int enemyCount;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        countGem.text = "0";
        playerText.text = "0";
    }
    public void UI_TextUpdate()
    {
        gemCounter++;
        countGem.text = gemCounter.ToString();
    }
    public void Player_UI_text()
    {
        enemyCount++;
        playerText.text = enemyCount.ToString();
    }


}
