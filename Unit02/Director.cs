using System;
using System.Collections.Generic;

namespace Unit02
{
    //Runs the Hilo game.
    public class Director
    {
        //Variables for the game.
        Card card = new Card();
        bool play = true;
        int win = 100;
        int lose = 75;
        int total = 300;
        int current;
        int next;

        //Generates a card and adds it to the cards list.
        public Director() {
        }

        //Loops the game until the player says stop, pulling a new card each loop.
        public void Start() {
            card.Pull();
            current = card.value;
            while (play) {
                playGame();
            }
        }

        //Runs the game.
        public void playGame() {
            //Tells the player what the current card is.
            Console.WriteLine($"The card is {current}");
            if (!play) {
                return;
            }
            //Pulls a new card for the next card to compare.
            card.Pull();
            next = card.value;
            
            //Prompts the user for a guess and rewards or removes points accordingly.
            Console.Write("Higher or Lower? [h/l] ");
            string guess = Console.ReadLine();
            Console.WriteLine($"Next card was {next}");
            if (guess.Equals("h") && current < next){
                total += win;
            } else if (guess.Equals("l") && current > next) {
                total += win;
            } else if (current == next) {
                total += 0;
            } else {
                total -= lose;
            }
            Console.WriteLine($"Your score is {total}");
            if (total == 0) {
                play = false;
            }
            
            //Prompts the user if they want to play again.
            current = next;
            Console.Write("Play Again? [y/n] ");
            string playAgain = Console.ReadLine();
            play = playAgain == "y";
        }

    }
}
