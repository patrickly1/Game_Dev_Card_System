using UnityEngine;

public class TestCardManager : MonoBehaviour
{
    public CardManager cardManager; // Reference to CardManager

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Create some cards
        Card card1 = new Card { cardName = "Fireball", cardValue = 2, suit = CardSuit.Hearts };
        Card card2 = new Card { cardName = "Idk", cardValue = 5, suit = CardSuit.Spades };

        // Add cards to the manager
        cardManager.AddCard(card1);
        cardManager.AddCard(card2);

        // Cast a card
        cardManager.CastCard(0);

        // Drop a card
        cardManager.DropCard(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
