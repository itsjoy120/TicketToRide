using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainCardPool : MonoBehaviour
{
    public TicketToRideDrawPile drawPile;  // Reference to the DrawPile script
    public Transform cardPoolTransform;  // Transform for positioning the cards in the pool

    public int maxCardsInPool = 5;  // Maximum number of cards in the pool
    private List<GameObject> cardPool;  // Face-up train card pool

    private void Start()
    {
        cardPool = new List<GameObject>();
        TurnOverCards();
    }

    // Turn over cards from the draw pile to the pool
    public  void TurnOverCards()
    {
        int cardsRemaining = maxCardsInPool - cardPool.Count;
        for (int i = 0; i < cardsRemaining; i++)
        {
            GameObject drawnCard = drawPile.DrawTicketCard();
            if (drawnCard != null)
            {
                cardPool.Add(drawnCard);
                drawnCard.transform.SetParent(cardPoolTransform);
                drawnCard.transform.localPosition = new Vector3(i * 1.5f, 0f, 0f);  // Position the cards horizontally in the pool
                drawnCard.transform.rotation = Quaternion.Euler(0f, 180f, 0f);  // Rotate card to face up
            }
        }
    }
}

