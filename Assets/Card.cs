using UnityEngine;

[System.Serializable] // Allows this class to be serialized and shown in the Inspector
public class Card
{
    public string cardName; // Name of the card
    public string suit;     // Suit of the card
    public string ability;  // Description of the card's ability

    public void CastAbility()
    {
        // Logic for casting the ability
        Debug.Log($"Casting ability of {cardName} with suit {suit}");
    }
}