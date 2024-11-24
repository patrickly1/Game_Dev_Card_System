using UnityEngine;

public class CardPickUp : MonoBehaviour
{
    public Card card; // The card data associated with this object
    private bool isPlayerNearby = false; // To check if the player is in range
    private GameObject player; // Reference to the player GameObject

    void Update()
    {
        // Check if the player presses a key (e.g., E) and is within range
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            // Call AddCard from the player's CardManager
            if (player != null)
            {
                CardManager cardManager = player.GetComponent<CardManager>();
                if (cardManager != null)
                {
                    cardManager.AddCard(card); // Add card to inventory
                    Debug.Log($"Picked up card: {card.cardName}");
                    Destroy(gameObject); // Remove the card object from the scene
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = true;
            player = other.gameObject;
            Debug.Log("Player is near the card. Press 'E' to pick it up.");
        }
    }

    void OnTriggerExit(Collider other)
    {
        // If the player moves away, reset the flag
        if (other.CompareTag("Player"))
        {
            isPlayerNearby = false;
            player = null;
            Debug.Log("Player moved away from the card.");
        }
    }
}