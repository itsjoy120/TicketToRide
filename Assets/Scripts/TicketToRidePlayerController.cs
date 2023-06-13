using UnityEngine;

public class TicketToRidePlayerController : MonoBehaviour
{
    public TicketToRideDrawPile ticketDrawPile;  // Reference to the TicketToRideDrawPile script
    public Transform handTransform;  // Transform for positioning the cards in the player's hand

    public int maxTicketsInHand = 10;  // Maximum number of tickets in the player's hand
    private int ticketsInHand = 0;  // Number of tickets currently in the player's hand

    public TicketToRidePlayerController[] players; // Array of player controllers

    private void Start()
    {
        DrawInitialTickets();

        // Example usage: Access each player controller in the array
        for (int i = 0; i < players.Length; i++)
        {
            TicketToRidePlayerController player = players[i];
            TicketToRidePlayerController player2 = players[i];
            TicketToRidePlayerController player3 = players[i];
            TicketToRidePlayerController player4 = players[i];
            player.DrawInitialTickets();
        }
    }

    // Draw initial tickets for the player
    private void DrawInitialTickets()
    {
        for (int i = 0; i < maxTicketsInHand; i++)
        {
            DrawTicket();
        }
    }

    // Draw a ticket from the draw pile
    public void DrawTicket()
    {
        if (ticketsInHand < maxTicketsInHand)
        {
            GameObject ticketCard = ticketDrawPile.DrawTicketCard();
            if (ticketCard != null)
            {
                ticketCard.transform.SetParent(handTransform);
                ticketCard.transform.localPosition = Vector3.zero;
                ticketsInHand++;
            }
        }
        else
        {
            Debug.LogWarning("Player's hand is full!");
        }
    }
}

