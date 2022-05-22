using System;
using UnityEngine;
namespace CardShuffle.Assets.Models
{
    public class Card //: MonoBehaviour
    {
        public Card(CardType cardType, string faceValue, Vector3 centerPointInSpace){
            CardType = cardType;
            FaceValue = faceValue;
            CenterPointInSpace = centerPointInSpace;
        }
        public CardType CardType { get; set; }
        public string FaceValue { get; set; }
        public Vector3 CenterPointInSpace {get;set;}
        //public Vector3 TopLeftOfCardInSpace {get;set;}
        //public Vector3 TopRightOfCardInSpace {get;set;}
        //public Vector3 BottomLeftOfCardInSpace {get;set;}
        //public Vector3 BottomRightOfCardInSpace {get;set;}
    }
}