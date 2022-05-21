using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardShuffle.Assets.Models;

public class InitiateGame : MonoBehaviour
{
    private List<Card> _cards = new List<Card>();
    // Start is called before the first frame update
    void Start()
    {
        for (var x = 0.0f; x < 51; x++)
        {
            _cards.Add(
                new Card(CardType.Club, x.ToString(),
                    new Vector3(
                        2f - 20.1f * x, 
                        2f + 20.1f * x,
                        2f
                    )
                )
            );
        }

        foreach(var card in _cards) {
            //Instantiate(CardPlaceholderPrefab, card.CenterPointInSpace, Quaternion.identity);
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
