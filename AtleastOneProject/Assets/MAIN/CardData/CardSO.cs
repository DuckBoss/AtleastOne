//!DOC
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AtleastOne.Templates.Cards;

//!na
namespace AtleastOne.ScriptableObjects.Cards
{
    //!c
    /*
    Name: CardSO
    Description: The Card scriptable object class which holds data on each card in the game.
    */
    public class CardSO : ScriptableObject
    {
        public int cardNumber;
        public CardType.CardClassification cardClassification;
    }
    //#c
}
//#na