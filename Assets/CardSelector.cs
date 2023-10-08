using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardSelector : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    [SerializeField] private UnityEvent<Card> onCardSelected;

    [SerializeField] List<Card> cards;
    private Card selectedCard;
    //private Card pickedCard;
    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (cards.Count > 0)
        {
            cards[0].OnCardSelected();
            selectedCard = cards[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (currentIndex == 0)
                {
                    currentIndex = cards.Count - 1;
                }
                else
                {
                    currentIndex--;
                }

                selectedCard.OnCardUnselected();
                selectedCard = cards[currentIndex];
                selectedCard.OnCardSelected();
                //onCardSelected?.Invoke(selectedCard);
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (currentIndex == cards.Count - 1)
                {
                    currentIndex = 0;
                }
                else
                {
                    currentIndex++;
                }

                selectedCard.OnCardUnselected();
                selectedCard = cards[currentIndex];
                selectedCard.OnCardSelected();
                //onCardSelected?.Invoke(selectedCard);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                onCardSelected?.Invoke(selectedCard); // Only print the card's name when spacebar is pressed.
            }
            // ... rest of your code
            gameManager.SetSelectedCard(selectedCard);
        }
    }
}