using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//!n
namespace AtleastOne.Templates.Cards
{
    
    //!c
    /*
     Name: Card
     Description: The base template class for cards in the game.
     */
    public class Card
    {
        private int _cardID;
        protected internal int CardID 
        {
            get { return _cardID; }
            set { _cardID = (value >= 0) ? value : 0; }
        }
        protected internal string CardName { get; set; }

        //!s
        /*
         Name: ToString
         Description: Returns a string interpretation of the card class.
         */
        public override string ToString()
        {
            return $"Card (ID - {CardID}, Name - {CardName})";
        }
        //#s
    }
    //#c
}
//#n