using UnityEngine;

[CreateAssetMenu(fileName = "New Ticket Card", menuName = "Ticket Card")]
public class TicketCard : ScriptableObject
{
    public string startingCity;     // Starting city of the ticket
    public string destinationCity;  // Destination city of the ticket
    public int pointValue;          // Point value of the ticket

    // Optional: You can add additional properties and methods as per your game's requirements
}

