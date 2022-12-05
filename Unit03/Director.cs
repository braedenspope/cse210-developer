using System;
using System.Collections.Generic;

namespace Unit03
{
    //Runs the game.
    class Director
    {
        //Variables.
        private bool play = true;
        private string chosen;
        HiddenWord word = new HiddenWord();
        private Jumper jumper = new Jumper();
        private TerminalService terminal = new TerminalService();
        public List<char> guesses = new List<char>();
        public int attempts = 0;
        public int num = 0;
        private bool checkInput;
        private string current = "";


        //Constructor.
        public Director() { 
        }

        //Runs the game while player has enough guesses left.
        public void Start(){
            beginGame();
            while (play){
                inputs();
                updates();
                outputs();

            }

        }

        //Gets the word and displays the hint.
        public void beginGame(){
            chosen = word.pickWord();
            word.getListFromWord(chosen);
            word.getAnswer();
            word.printGuess();
        }

        //Handles input into the game and checks if it's valid.
        public void inputs(){
            Console.WriteLine("\n");
            jumper.printJumper(attempts);
            checkInput = true;
            while (checkInput){
                current = terminal.ReadGuess("\nGuess a letter [a-z]: ");
                checkInput = jumper.checkInput(guesses, current);
            }
            guesses.Add(current[0]);
        }

        //Checks if the guessed character is in the word and if the player has more guesses left.
        private void updates(){
            num = guesses.Count;
            int used = word.compare(guesses, num);
            attempts += used;
            play = jumper.check(word.guess, attempts);
        }

        //Displays the jumper and hint line.
        private void outputs(){
            Console.WriteLine("\n");
            if (play){
                word.printGuess();
            } else {
                jumper.printJumper(attempts);
                word.printAnswer();
                Console.WriteLine("\n");
            }
        }
    }
}