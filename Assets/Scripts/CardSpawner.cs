using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CardSpawner : MonoBehaviour
{
    public List<CardDescription_SO> cards;
    public GameObject[] spawnLocations;
    
    public GameObject cardTemplate;

    private List<CardDescription_SO> availableCards;
    
    private void Start()
    {
        availableCards = new List<CardDescription_SO>(cards);
        Invoke("GenerateCards", 0.5f);
    }

    void GenerateCards()
    {
        foreach (GameObject loc in spawnLocations)
        {
            int RandomCard = Random.Range(0, cards.Count);

            GenerateCard(loc, RandomCard);
            cards.RemoveAt(RandomCard);
        }
    }

    void GenerateCard(GameObject loc, int RandomCard)
    {
        GameObject card = Instantiate(cardTemplate, loc.transform.position, Quaternion.identity);
        card.transform.parent = loc.transform;
        card.GetComponentInChildren<Card>().activeCard = cards[RandomCard];
    }
}
