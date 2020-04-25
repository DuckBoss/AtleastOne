//!DOC
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AtleastOne.Templates.Cards;
using System.Linq;

//!na
namespace AtleastOne.Templates.Deck
{
    //!c
    /*
    Name: Deck
    Description: The Deck class holds cards and handles various deck operations such as shuffling.
    */
    internal class Deck
    {
        private int _deckSize = 0;
        protected internal int DeckSize
        {
            get { return _deckSize; }
            set { _deckSize = value >= 0 ? value : 0; }
        }

        protected internal List<Card> Cards;

        //!s
        /*
        Name: Deck
        Description: The Deck constructur initializes the Deck class.
        */
        public Deck(int deckSize)
        {
            this.DeckSize = deckSize;
        }
        //#s

        //!s
        /*
        Name: Shuffle
        Description: Shuffles the cards in the deck randomly by generating new random Guid's and sorting them.
        */
        protected void Shuffle()
        {
            this.Cards = this.Cards.OrderBy(i => System.Guid.NewGuid()).ToList();
        }
        //#s

        //!s
        /*
        Name: ToString
        Description: Returns a string representation of the Deck class.
        */
        public override string ToString()
        {
            return $"Deck - " + string.Join(", ", this.Cards.ToArray<object>());
        }
        //#s
    }
    //#c
}
//#na