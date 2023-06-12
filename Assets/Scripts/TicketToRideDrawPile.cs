using System.Collections.Generic;
using UnityEngine;

public class TicketToRideDrawPile : MonoBehaviour
{
    public List<GameObject> ticketCards; // List of ticket card prefabs

    private List<GameObject> drawPile; // Draw pile of ticket card game objects

    private void Start()
    {
        InitializeDrawPile();
        ShuffleDrawPile();
    }

    // Initialize the draw pile with ticket card game objects
    private void InitializeDrawPile()
    {
        drawPile = new List<GameObject>(ticketCards);
    }

    // Shuffle the draw pile using Fisher-Yates algorithm
    private void ShuffleDrawPile()
    {
        for (int i = 0; i < drawPile.Count; i++)
        {
            int randIndex = Random.Range(i, drawPile.Count);
            GameObject tempCard = drawPile[randIndex];
            drawPile[randIndex] = drawPile[i];
            drawPile[i] = tempCard;
        }
    }

    // Draw a ticket card from the top of the pile
    public GameObject DrawTicketCard()
    {
        if (drawPile.Count > 0)
        {
            GameObject drawnCard = drawPile[0];
            drawPile.RemoveAt(0);
            return drawnCard;
        }
        else
        {
            Debug.LogWarning("Draw pile is empty!");
            return null;
        }
    }
}

