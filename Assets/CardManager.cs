using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<Card> cardInventory = new List<Card>(); // List to store cards

    public void AddCard(Card card)
    {
        cardInventory.Add(card);
        Debug.Log($"Added card: {card.cardName}");
    }

    public void DropCard(int index)
    {
        if (index >= 0 && index < cardInventory.Count)
        {
            Debug.Log($"Dropped card: {cardInventory[index].cardName}");
            cardInventory.RemoveAt(index);
        }
        else
        {
            Debug.LogError("Invalid index: Cannot drop card.");
        }
    }

    public void CastCard(int index)
    {
        if (index >= 0 && index < cardInventory.Count)
        {
            Card card = cardInventory[index];
            card.CastAbility();
        }
        else
        {
            Debug.LogError("Invalid index: Cannot cast card.");
        }
    }
}