using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardShuffle.Assets.Models;

public class InitiateGame : MonoBehaviour
{
    public GameObject CardPlaceholderPrefab; //Greg new
    private List<Card> _cards = new List<Card>();
    public float i;
    //public Random _random = new Random();
    // Start is called before the first frame update
    public abstract class ShuffleList
    {
    //Define shuffling algorithm
      public static List<E> ShuffleListItems<E>(List<E> inputList)
      {
        List<E> originalList = new List<E>();
        originalList.AddRange(inputList);
        List<E> randomList = new List<E>();

        System.Random r = new System.Random();
        int randomIndex = 0;
        while (originalList.Count > 0)
        {
            randomIndex = r.Next(0, originalList.Count); //Choose a random object in the list
            randomList.Add(originalList[randomIndex]); //add it to the new, random list
            originalList.RemoveAt(randomIndex); //remove to avoid duplicates
        }

        return randomList; //return the new random list
      }
    }
    void Start()
    {   
        //Generate Clubs
        for (int x = 2; x < 15; x++)
        {
            _cards.Add(
                new Card(CardType.Club, x.ToString(),
                    new Vector3(x, 0.2f , 0)
                )
            );
        }
        //Generate Hearts
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

        //Shuffle _cards List
        List<Card> shuffledDeck = ShuffleList.ShuffleListItems<Card>(_cards);

        //Spawn Shuffled Deck into space
        foreach(var card in shuffledDeck) {
            var nextCard = Instantiate(CardPlaceholderPrefab, new Vector3(i*0.001f,i*0.025f,0f), Quaternion.identity);
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
            i = i+1f;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
