using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardConsumer : MonoBehaviour
{
    public void ConsumeCard(Card card)
    {
        Debug.Log(card.gameObject.name);
        //return card.gameObject.name;
    }
}