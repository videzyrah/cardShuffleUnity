using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardShuffle.Assets.Models;

public class InitiateGame : MonoBehaviour
{
    public GameObject CardPlaceholderPrefab; //Greg new
    private List<Card> _cards = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 2; x < 15; x++)
        {
            _cards.Add(
                new Card(CardType.Club, x.ToString(),
                    new Vector3(x, 0.2f , 0)
                )
            );
        }
        for (int x = 2; x < 15; x++)
        {
            _cards.Add(
                new Card(CardType.Heart, x.ToString(),
                    new Vector3(x, 0.4f , 0)
                )
            );
        }
        for (int x = 2; x < 15; x++)
        {
            _cards.Add(
                new Card(CardType.Spade, x.ToString(),
                    new Vector3(x, 0.6f , 0)
                )
            );
        }
        for (int x = 2; x < 15; x++)
        {
            _cards.Add(
                new Card(CardType.Diamond, x.ToString(),
                    new Vector3(x, 0.8f , 0)
                )
            );
        }



        foreach(var card in _cards) {
            var nextCard = Instantiate(CardPlaceholderPrefab, card.CenterPointInSpace, Quaternion.identity);
            Debug.Log((int)card.CardType);
            if ((int)card.CardType == 1){
               nextCard.GetComponent<CardGreg>().suit = "Club"; 
            }
            if ((int)card.CardType == 2){
               nextCard.GetComponent<CardGreg>().suit = "Heart"; 
            }
            if ((int)card.CardType == 3){
               nextCard.GetComponent<CardGreg>().suit = "Spade"; 
            }
            if ((int)card.CardType == 4){
               nextCard.GetComponent<CardGreg>().suit = "Diamond"; 
            }
            nextCard.GetComponent<CardGreg>().value = card.FaceValue;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
