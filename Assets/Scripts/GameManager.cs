using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton pattern
    public static GameManager Instance;
    GameOverCanvasControl gameOverCanvasControl;

    ////FIXME Scene Management from GPT suggestion
    //public Player player;  // Reference to the Player script
    //public string selectorSceneName = "SelectorScene"; // Assuming your card selector scene is named "SelectorScene"
    //private const int ageDecreaseValue = 10; // Value to check against for scene load

    // CardDeck cardDeck;
    private Card selectedCard;
    private int timer = 0;
    public void SetSelectedCard(Card card)
    {
        this.selectedCard = card;
    }

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

    public void FetchSelectedCardDetails()
    {
        if (selectedCard != null)
        {
            Debug.Log("Selected Card Name: " + selectedCard.gameObject.name);
            Debug.Log("Age Increment: " + selectedCard.AgeIncrement);
            Debug.Log("Speed Factor: " + selectedCard.speedFactor);
            Debug.Log("Gravity Factor: " + selectedCard.gravityFactor);
        }
        else
        {
            Debug.Log("No card selected.");
        }
    }
    ////FIXME
    //// Start is called before the first frame update
    //void Start()
    //{
    //    // You can directly reference the Player's Age if it's public or through a method if it's encapsulated
    //    if (player != null)
    //    {
    //        player.OnAgeChanged += CheckAge; // Assuming you have an event in the player script that's raised when age changes
    //    }
    //}

    //private void CheckAge(int newAge)
    //{
    //    if (newAge % ageDecreaseValue == 0)
    //    {
    //        StartCoroutine(ShowCardSelector());
    //    }
    //}

    //private IEnumerator ShowCardSelector()
    //{
    //    // Pause your game
    //    Time.timeScale = 0;

    //    // Load the selector scene additively
    //    yield return SceneManager.LoadSceneAsync(selectorSceneName, LoadSceneMode.Additive);

    //    // You can have a trigger in your Selector scene which will notify the GameManager once the card is selected
    //    yield return new WaitUntil(() => /* condition to check card has been selected */);

    //    // Unload the selector scene
    //    SceneManager.UnloadSceneAsync(selectorSceneName);

    //    // Resume the main game
    //    Time.timeScale = 1;
    //}
    //// Make sure to unsubscribe from events when this object is destroyed
    //private void OnDestroy()
    //{
    //    if (player != null)
    //    {
    //        player.OnAgeChanged -= CheckAge;
    //    }
    //}
//code above from GPT suggestion
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FetchSelectedCardDetails();
        }
    }
    //TODO intro game over screen
    public void GameOver() {
        GameOverCanvasControl gocc = GetComponent<GameOverCanvasControl>();
        gocc.Display();
    }

    public void DisplayCardSelection() {
   //     cardDeck = GetComponent<CardDeck>();
    }
}
