using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    [SerializeField] private UnityEvent onCardSelected;
    [SerializeField] private UnityEvent onCardUnselected;
    [SerializeField] private UnityEvent onCardEnterPressed;

    public float AgeIncrement;
    public float speedFactor;
    public float gravityFactor;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            OnCardEnterPressed();
        }
    }

    public void OnCardSelected()
    {
        onCardSelected?.Invoke();
    }

    public void OnCardUnselected()
    {
        onCardUnselected?.Invoke();

    }
    public void OnCardEnterPressed()
    {
        onCardEnterPressed?.Invoke();
    }
}
