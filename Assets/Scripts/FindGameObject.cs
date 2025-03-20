using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindGameObject : MonoBehaviour
{
    private GameManager gameManager;
    public void EndGame()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if(gameManager != null )
            gameManager.EndGame();
    }
}
