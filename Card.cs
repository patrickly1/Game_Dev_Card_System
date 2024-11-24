using UnityEngine;
using System;

[System.Serializable] // Allows this class to be serialized and shown in the Inspector

// enum type representing the card suit
public enum CardSuit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    };

// Stores information for one card
public class Card 
{
    public string cardName;
    public int cardValue;
    public CardSuit suit;
    
    // calls the specific ability function based on suit
    public void CastAbility()
    {
        switch(suit)
        {
            case CardSuit.Hearts:
                HeartsAbility();
                break;
            case CardSuit.Diamonds:
                DiamondsAbility();
                break;
            case CardSuit.Clubs:
                ClubsAbility();
                break;
            case CardSuit.Spades:
                SpadesAbility();
                break;
        }
    }

    public void HeartsAbility() 
    {
        Console.WriteLine("Activated Hearts Ability");
        Debug.Log($"Activated Hearts Ability {cardName}");
    }

    public void DiamondsAbility() 
    {
        Console.WriteLine("Activated Diamonds Ability");
        Debug.Log($"Activated Diamonds Ability {cardName}");
    }

    public void ClubsAbility() 
    {
        Console.WriteLine("Activated Clubs Ability");
        Debug.Log($"Activated Clubs Ability {cardName}");
    }

    public void SpadesAbility() 
    {
        Console.WriteLine("Activated Spades Ability");
        Debug.Log($"Activated Spades Ability {cardName}");
    }
}