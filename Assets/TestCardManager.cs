using UnityEngine;

public class TestCardManager : MonoBehaviour
{
    public CardManager cardManager; // Reference to CardManager

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Create some cards
        Card card1 = new Card { cardName = "Fireball", suit = "Hearts", ability = "Deal 50 damage" };
        Card card2 = new Card { cardName = "Shield", suit = "Spades", ability = "Block 20 damage" };

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
