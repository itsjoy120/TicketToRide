using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TicketToRidePlayerController playerController;  // Reference to the TicketToRidePlayerController script

    public TicketCard ticketCard;  // Reference to the TicketCard asset

    public TicketToRideDrawPile drawPile;  // Reference to the DrawPile script
    public TrainCardPool trainCardPool;  // Reference to the TrainCardPool script

    private void Start()
    {
        // Example usage: Call the DrawTicket method to draw a ticket for the player
        playerController.DrawTicket();

        // Example usage: Access and modify ticket card properties
        ticketCard.startingCity = "New York";
        ticketCard.destinationCity = "Los Angeles";
        ticketCard.pointValue = 20;

        // Example usage: Retrieve ticket card information
        string startingCity = ticketCard.startingCity;
        string destinationCity = ticketCard.destinationCity;
        int pointValue = ticketCard.pointValue;

        Debug.Log("Ticket Card: " + startingCity + " to " + destinationCity + " - Points: " + pointValue);

        // Example usage: Initialize draw pile and populate train card pool
        drawPile.InitializeDrawPile();
        trainCardPool.TurnOverCards();
    }
}

