using UnityEngine;

public class TicketCardHandler : MonoBehaviour
{
    public TicketToRideDrawPile drawPile;  // Reference to the TicketToRideDrawPile script

    private void Start()
    {
        // Example usage: Draw a ticket card
        GameObject drawnCard = drawPile.DrawTicketCard();
        if (drawnCard != null)
        {
            // Handle the drawn ticket card (e.g., instantiate it, assign to a player, etc.)
            // ...
        }
    }
}
