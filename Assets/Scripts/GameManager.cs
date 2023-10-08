using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton pattern
    public static GameManager Instance;
    GameOverCanvasControl gameOverCanvasControl;
// CardDeck cardDeck;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver() {//TODO intro game over screen
        GameOverCanvasControl gocc = GetComponent<GameOverCanvasControl>();
        gocc.Display();
    }

    public void DisplayCardSelection() {
   //     cardDeck = GetComponent<CardDeck>();
    }
}
