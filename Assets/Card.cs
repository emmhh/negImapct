using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Card : MonoBehaviour
{
    [SerializeField] private UnityEvent onCardSelected;
    [SerializeField] private UnityEvent onCardUnselected;

    public float AgeIncrement;
    public float speedFactor;
    public float gravityFactor;

    public void OnCardSelected()
    {
        onCardSelected?.Invoke();
    }

    public void OnCardUnselected()
    {
        onCardUnselected?.Invoke();

    }
}
