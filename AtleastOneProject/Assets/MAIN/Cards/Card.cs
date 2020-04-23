//!DOC
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//!na
namespace AtleastOne.Templates.Cards
{
    
    //!c
    /*
    Name: Card
    Description: The base template class for cards in the game.
    */
    internal class Card
    {
        protected internal string CardID { get; set; }
        protected internal int CardNumber { get; set; }
        protected internal CardType.CardClassification CardCategory { get; set; }

        //!s
        /*
        Name: Card
        Description: The Card constructor is used to create cards objects.
        //!p The number to assign to the card. //#p
        //!p The type/category of card to assign to the card. //#p
        */
        public Card(int cardNumber, CardType.CardClassification cardType)
        {
            this.CardNumber = cardNumber;
            this.CardCategory = cardType;
            this.GenerateCardID();
        }
        //#s
        
        //!s
        /*
        Name: GenerateCardID
        Description: Generates a Card ID with the first letter of the category and the absolute value of the card number.
        */
        protected void GenerateCardID()
        {
            this.CardID = $"{this.CardCategory.ToString()[0]}{Mathf.Abs(this.CardNumber)}";
        }
        //#s

        //!s
        /*
        Name: ToString
        Description: Returns a string interpretation of the card class.
        */
        public override string ToString()
        {
            return $"Card (ID - {this.CardID}, Number - {this.CardNumber}, Type - {this.CardCategory})";
        }
        //#s
    }
    //#c
}
//#na