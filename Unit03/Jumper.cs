using System;
using System.Collections.Generic;

namespace Unit03
{
    //Handles the attributes of the jumper.
    class Jumper
    {
        //List of strings that make up the jumper picture. 
        private List<string> jumper = new List<string>();

        //count of attempts made by the player.
        private int count;

        //correct guesses from the player.
        public int correctTries = 0;


        //Constructor.
        public Jumper() {
            jumper.Add("  ___");
            jumper.Add(" /___\\");
            jumper.Add(" \\   /");
            jumper.Add("  \\ /");
            jumper.Add("   O");
            jumper.Add("  /|\\");
            jumper.Add("  / \\");    
        }

        //Checks that the character entered isn't one already guessed.
        public bool checkInput(List<char> guesses, string current){
            if (guesses.Contains(current[0])){
                Console.WriteLine("That letter has been guessed already. Try Again.");
                return true;
            } else {
                return false;
            }
        } 

        //checks if the player has run out of attempts.
        public bool check(List<char> guess, int attempts) {
            count = 0;
            for (int i = 0; i < guess.Count; i++){
                if (guess[i] != '_'){
                    count++;
                }
            }
            if (correctTries == 3 || count == guess.Count){
                return false;
            } else {
                return true;
            }
        }

        //prints the jumper based on the number of attempts.
        public void printJumper(int tries){
            if (tries == correctTries){

            } else if (tries == 4){
                jumper.RemoveRange(0,1);
                jumper[0] = "   X";
            } else {
                jumper.RemoveRange(0,1);
                correctTries++;
            }
            for (int i = 0; i < jumper.Count; i++){
                Console.WriteLine(jumper[i]);
            }
        }      


    }
}