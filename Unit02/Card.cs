using System;

namespace Unit02
{
    //Generates a card with a random value.
    public class Card {
        
        //Value of the card.
        public int value;

        //Constructor
        public Card() {}

        //Generates a random number between 1 and 13 for the card.
        public void Pull() {
            Random rand = new Random();
            value = rand.Next(1, 14);
        }
    }


}