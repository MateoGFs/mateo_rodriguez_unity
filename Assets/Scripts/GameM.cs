using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour
{
    public static GameM Instance;
    public GameObject gameOverText; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Awake()
    {
        Instance = this;
        if (gameOverText != null)
            gameOverText.SetActive(false);
    }

    public void GameOver()
    {
        Debug.Log("¡Juego Terminado!");
        if (gameOverText != null)
        {
            gameOverText.SetActive(true);
        }
        
        Time.timeScale = 0f;
    }
}
